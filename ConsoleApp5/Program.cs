using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new(MyFunc);
            thread1.Start();
            MyFunc2();
            
        }

        public static void MyFunc()
        {
            Console.WriteLine("i am 1");
            Thread.Sleep(1000);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void MyFunc2()
        {
            Console.WriteLine("i am 2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
