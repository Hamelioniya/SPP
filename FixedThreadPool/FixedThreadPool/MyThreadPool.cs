using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace FixedThreadPool
{
    public class MyThreadPool : IDisposable
    {
        private static Logger logger;

        private int numberThreads;
        private Task[] threads;
        private List<ThreadTask> tasks;

        private ManualResetEvent stopEvent;
        private bool isStoping;
        private object stopLock;

        private ManualResetEvent scheduleEvent;
        private bool isHaveTasks;

        private bool isDisposed;

        public MyThreadPool(int numberThreads)
        {
            logger = LogManager.GetCurrentClassLogger();

            if (numberThreads <= 0)
            {
                logger.Error("Количество потоков должно быть больше нуля.");
                throw new ArgumentException("Количество потоков должно быть больше нуля.", numberThreads.ToString());
            }
            this.numberThreads = numberThreads;
            this.threads = new Task[numberThreads];
            for (int i = 0; i < numberThreads; i++)
            {
                threads[i] = new Task(() => ThreadWork(), TaskCreationOptions.LongRunning);
                logger.Info("Был создан поток с номером " + threads[i].Id);
            }

            this.tasks = new List<ThreadTask>();

            this.stopLock = new object();
            this.stopEvent = new ManualResetEvent(false);

            isHaveTasks = false;
            this.scheduleEvent = new ManualResetEvent(false);
        }

        private ThreadTask SelectTask()
        {
            lock (tasks)
            {
                if (tasks.Count != 0)
                {
                    var notRunnedLowTasks = tasks.Where(t => !t.IsRunned && t.Priority == Priority.Low);
                    var notRunnedNormalTasks = tasks.Where(t => !t.IsRunned && t.Priority == Priority.Normal);
                    var notRunnedHighTasks = tasks.Where(t => !t.IsRunned && t.Priority == Priority.High);

                    if (notRunnedHighTasks.Count() > 0)
                        return notRunnedHighTasks.First();
                    else
                    {
                        if (notRunnedNormalTasks.Count() > 0)
                        {
                            return notRunnedNormalTasks.First();
                        }
                        else
                        {
                            return notRunnedLowTasks.FirstOrDefault();
                        }
                    }
                }
                else
                    return null;
            }
        }

        private void ThreadWork()
        {
            while (true)
            {
                ThreadTask task = SelectTask();
                if (task != null)
                {
                    try
                    {
                        task.Execute();
                    }
                    finally
                    {
                        RemoveTask(task);
                        if (isStoping)
                            stopEvent.Set();
                    }
                }
            }
        }

        //Менеджер потоков(тасков)
        public void ThreadManager()
        {
            while (true)
            {
                scheduleEvent.WaitOne(3000);
                lock (threads)
                {
                    if (!isHaveTasks)
                        break;
                    foreach (var thread in threads)
                    {
                        if ((thread.Status == TaskStatus.Created) | (thread.Status == TaskStatus.WaitingForActivation))
                        {
                            logger.Info("Потоку с номером " + thread.Id + "была назначена работа.");

                            thread.Start();
                            break;
                        }
                        if (thread.Id == threads[threads.Length - 1].Id)
                        {
                            logger.Info("Нет свободного потока для выполнения задачи.");
                            Console.WriteLine("Нет свободного потока для выполнения задачи!");
                        }
                    }
                }
                scheduleEvent.Reset();
            }
        }

        //Добавление задачи в список
        private void AddTask(ThreadTask task)
        {
            lock (tasks)
            {
                tasks.Add(task);

                if (!isHaveTasks)
                    isHaveTasks = true;
            }

            scheduleEvent.Set();
        }

        //Удаление задачи из очереди
        private void RemoveTask(ThreadTask task)
        {
            lock (tasks)
            {
                tasks.Remove(task);

                if ((tasks.Count > 0) & (tasks.Where(t => !t.IsRunned).Count() > 0))
                    scheduleEvent.Set();
                else
                    isHaveTasks = false;
            }
        }

        //Установка задачи в очередь
        public bool Execute(ThreadTask task)
        {
            if (task == null)
            {
                logger.Error("Значение задачи не должно быть равно null!");
                throw new ArgumentNullException("task", "Значение не должно быть равно null!");
            }

            lock (stopLock)
            {
                if (isStoping)
                {
                    return false;
                }

                AddTask(task);
                return true;
            }
        }

        // Останавливает работу пула потоков. Ожидает завершения всех задач (запущенных и стоящих в очереди) и уничтожает все ресурсы.
        public void Stop()
        {
            lock (stopLock)
            {
                isStoping = true;
            }

            while (tasks.Count > 0)
            {
                stopEvent.WaitOne();
                stopEvent.Reset();
            }

            Dispose(true);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    scheduleEvent.Dispose();
                }

                isDisposed = true;
            }
        }
    }
}
