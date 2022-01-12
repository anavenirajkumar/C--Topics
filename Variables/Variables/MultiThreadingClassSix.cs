using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread
using System.Diagnostics;

namespace Variables
{
    class MultiThreadingClassSix
    {
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Incrementounter1: " + Count);
        }

        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
            {
                Count++;
            }
            Console.WriteLine("Incrementounter2: " + Count);
        }
        static void Main()
        {


            Stopwatch s1 = new Stopwatch(); // Single Thread
            Stopwatch s2 = new Stopwatch(); // Single Thread

            Thread t1 = new Thread(IncrementCounter1); // Multi Thread
            Thread t2 = new Thread(IncrementCounter2); // Multi Thread

            s1.Start();   // Single Thread Start
            IncrementCounter1();   // Multi Thread Start
            IncrementCounter2();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();


            t1.Join();
            t2.Join();
            Console.WriteLine("Single Thread Time " + s1.ElapsedMilliseconds);
            Console.WriteLine("Multi Thread Time " + s2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}