using System;
using System.Threading;

namespace Multithreading
{
    internal class Program
    {
        public static void count()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Thread.Sleep(10000); 
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "My Thread";
            Console.WriteLine($"This Thread is Made by me: {Thread.CurrentThread.Name}");
            count();

        }
    }
}
