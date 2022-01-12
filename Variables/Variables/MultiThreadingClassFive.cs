using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread


namespace Variables
{
    class MultiThreadingClassFive
    { // Threding Priorities 
        // Thread Priorities : like VIP
        // Lowest,
        // Below Normal,
        // Normal -> Default
        // Above Normal,
        // Highest
        static long Count1, Count2;
        public static void IncrementCount1()
        {
            while (true) Count1 += 1;

        }
        public static void IcrementCount2()
        {
            while (true) Count2 += 1;

        }
        static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IcrementCount2);

            t1.Priority = ThreadPriority.Lowest; // Priority last
            t2.Priority = ThreadPriority.Highest; // Priority First

            t1.Start(); t2.Start();

            Console.WriteLine("Main thread going to Sleep");
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread woke up");

            t1.Abort();
            t2.Abort();

            t1.Join(); t2.Join();

            Console.WriteLine("Count1 : " + Count1);
            Console.WriteLine("Count2 : " + Count2);
            Console.ReadLine();

        }
    }
}