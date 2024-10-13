using System.Threading.Tasks;
using System.Collections.Concurrent;
using System;
using System.Threading;

namespace __lab19
{
    internal class Program
    {
        public static BlockingCollection<int> bc;
        static void Main()
        {
            // BlockingCollectionModuleTest();
            // TaskActionModuleTest();
            // TaskCurrentIdTest();
             TaskWaitTest();
        }

        // Listing 1.1
        public static void Producer()
        {
            for (int i = 0; i < 100; i++)
            {
                bc.Add(i * i);
                Console.WriteLine("Producer " + i * i);
            }
            bc.CompleteAdding();
        }
        public static void Consumer()
        {
            while (!bc.IsCompleted)
            {
                if (bc.TryTake(out int i))
                {
                    Console.WriteLine("Consumer: " + i);
                }
            }
        }
        private static void BlockingCollectionModuleTest()
        {
            bc = new BlockingCollection<int>(4);

            // Задачи поставщика и потребителя
            Task ProducerTask = new Task(Producer);
            Task ConsumerTask = new Task(Consumer);

            // Запуск задач
            ProducerTask.Start();
            ConsumerTask.Start();

            try
            {
                Task.WaitAll(ConsumerTask, ProducerTask);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally 
            { 
                ConsumerTask.Dispose();
                ProducerTask.Dispose(); 
                bc.Dispose();
            }
            Console.ReadKey();
        }

        // Listing 1.2
        public static void TaskActionModuleTest() {
            Console.WriteLine("Main threed started ");

            Task task = new Task(TaskAction);

            // Запуск задачи
            task.Start();

            for (int i = 0; i < 20; i++) 
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine("Main thread shutdown");
            Console.ReadKey();
        }
        public static void TaskAction()
        {
            Console.WriteLine("TaskAction started");

            for (int count = 0; count < 5; count++) 
            { 
                // Ждем 1 секунду (1000 мс)
                Thread.Sleep(1000);

                Console.WriteLine("Count: "+ count);
            }
        }

        // Listing 1.3
        public static void TaskAction2() 
        {
            Console.WriteLine($"TaskAction started, task {Task.CurrentId}");

            for (int count = 0; count < 10; count++) 
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Task {Task.CurrentId}, Count {count}");
            }
        }
        public static void TaskCurrentIdTest() 
        {
            Console.WriteLine("Main thread started");

            Task task1 = new Task(TaskAction2);
            Task task2 = new Task(TaskAction2);

            task1.Start();
            task2.Start();

            for (int i = 0; i < 25; i++) 
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine("Main thread shutdown");
            Console.ReadKey();
        }

        // Listing 1.4
        static void TaskAction3() 
        { 
            Console.WriteLine($"TaskAction started, task {Task.CurrentId}");

            for (int count = 0; count < 10; count++) { 
                Thread.Sleep(1000);

                Console.WriteLine($"Task {Task.CurrentId}, Count {count}");
            }
            Console.WriteLine($"End of task {Task.CurrentId}");
        }
        static void TaskWaitTest()
        {
            Console.WriteLine("Main thread started");

            Task task1 = new Task(TaskAction3);
            Task task2 = new Task(TaskAction3);

            task1.Start();
            task2.Start();

            Console.WriteLine("Waiting...");
            task1.Wait();
            task2.Wait();

            Console.WriteLine("Main thread shutdown");
            Console.ReadKey();
        }
    }
}
