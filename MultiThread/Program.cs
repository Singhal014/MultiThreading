using System.Threading;
using System;
namespace MultiThread
{
    
    public class Program
    {
        public static void count()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("t  " + i);
            }
        }
        public static void count1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("t1  "+i);
            }
        }
        public static void count2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("t2  "+i);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(count);
            Thread t1 = new Thread(count1);
            Thread t2 = new Thread(count2);

            t.Start(); t1.Start(); t2.Start();



        }
    }
}
