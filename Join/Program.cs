namespace Join
{
    internal class Program
    {
        public static void count()
        {
            Console.WriteLine("Thread 1 is Executing");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 1 is Exiting");


        }
        public static void count1()
        {
            Console.WriteLine("Thread 2 is Executing");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 2 is Exiting");

        }
        public static void count2()
        {
            Console.WriteLine("Thread 2 is Executing");

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 2 is Exiting");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is Executing");
            Thread t = new Thread(count);
            Thread t1 = new Thread(count1);
            Thread t2 = new Thread(count2);
            t.Start();t1.Start();t2.Start();
            t.Join(1000);t1.Join();t2.Join(); // join is used for main thread executing whole program without exit here i also give time like here if give t.join(3000) main thread exit after 3 sec 
            Console.WriteLine("Main Thread Is Exiting");

        }
    }
}
