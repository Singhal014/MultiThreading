using System.Threading;
namespace Thread_Lock
{
    internal class Program
    {
        public void Display()
        {
            lock (this){ 
            Console.Write("C# is an ");
            Thread.Sleep(5000);
            Console.WriteLine("oop language");
        }
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);    
            Thread t3 = new Thread(p.Display);

            t1.Start();t2.Start();t3.Start();
        }
    }
}
