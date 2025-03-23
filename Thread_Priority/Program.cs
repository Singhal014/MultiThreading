using System;
using System.Threading;

namespace Thread_Priority
{
    internal class Program
    {
        static long Count1, Count2;
        static volatile bool _stopThreads = false; // Flag to stop threads

        public static void Increment1()
        {
            while (!_stopThreads)
            {
                Count1 += 1;
            }
        }

        public static void Increment2()
        {
            while (!_stopThreads)
            {
                Count2 += 1;
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread going to sleep...");
            Thread.Sleep(3000); 
            Console.WriteLine("Main thread woke up!");

            // Stop the threads gracefully
            _stopThreads = true; // Use this for gracefully stop the thread 
            // Thread.Abort() is no longer supported in .NET Core and later versions

            t1.Join(); 
            t2.Join(); 

            Console.WriteLine("Count 1 = " + Count1);
            Console.WriteLine("Count 2 = " + Count2);
        }
    }
}
