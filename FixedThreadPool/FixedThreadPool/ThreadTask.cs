using System;
using System.Threading;

namespace FixedThreadPool
{
    public class ThreadTask
    {
        private Priority priority;
        private Action work;
        private bool isRunned;

        public ThreadTask(Action work) : this(work, Priority.Normal) { }

        //Создание задачи с указанным приоритетом
        public ThreadTask(Action work, Priority priority)
        {
            this.priority = priority;
            this.work = work;
        }

        // Выполнение задачи
        public void Execute()
        {
            lock (this)
            {
                isRunned = true;
            }
            work();
        }

        // Приоритет задачи. Устанавливается только при создании задачи.
        public Priority Priority
        {
            get
            {
                return priority;
            }
        }

        public bool IsRunned
        {
            get
            {
                return isRunned;
            }
        }

    }
}
