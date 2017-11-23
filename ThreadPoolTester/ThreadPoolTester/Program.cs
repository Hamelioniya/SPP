using FixedThreadPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThreadPool threadPool = new MyThreadPool(5);
            List<ThreadTask> tasks = new List<ThreadTask>();

            Console.WriteLine("Пул потоков готов к работе:");

            for (var i = 0; i < 20; i++)
            {
                tasks.Add(new ThreadTask(NormalPriority));
            }

            //Добавление задач в очередь
            foreach (ThreadTask task in tasks)
                threadPool.Execute(task);

            //Запуск менеджера пула потоков(распредление задач между потоками)
            threadPool.Run();
            threadPool.Stop();

            Console.WriteLine("Работа пула потоков завершена");
            Console.ReadLine();

        }

        public static void LowPriority()
        {
            Console.WriteLine("Приоритет: Low");
            Thread.Sleep(500);
        }

        public static void NormalPriority()
        {
            Console.WriteLine("Приоритет: Normal");
            Thread.Sleep(500);
        }

        public static void HighPriority()
        {
            Console.WriteLine("Приоритет: High");
            Thread.Sleep(500);
        }
    }
}
