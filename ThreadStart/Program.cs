using System;
using System.Threading;

namespace Thread_Start
{
    internal class Program
    {
        // This method doesn't accept any parameters, used with ThreadStart delegate
        public static void count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // This method accepts a parameter, used with ParameterizedThreadStart delegate
        public static void count1(object max)
        {
            int n = Convert.ToInt32(max);  // it not take other data type that why i take obj then convert to int
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // different ways of creating thread delegates work same as Thread t = new Thread(count);


            // This is the explicit way of creating a delegate for a method
            //ThreadStart obj = new ThreadStart(count);

            // This is a shorthand way of creating the delegate, the compiler implicitly makes the delegate
            //ThreadStart obj = count;  // This also works the same way, and the compiler makes the delegate.

            // You can also explicitly create a delegate using an anonymous method
            //ThreadStart obj = delegate() { count(); };  // This also works the same way and creates a delegate.

            // Using a lambda expression to create the delegate
            //ThreadStart obj = () => count();  // This also works the same as the previous examples.

            // using ParameterizedThreadStart delegate for methods that take parameters

            ParameterizedThreadStart obj1 = new ParameterizedThreadStart(count1);
            Thread t1 = new Thread(obj1);
            t1.Start(50);

            // use ThreadStart for non ParameterizedThreadStart
            ThreadStart obj = new ThreadStart(count);
            Thread t = new Thread(obj);
            t.Start();
        }
    }
}
