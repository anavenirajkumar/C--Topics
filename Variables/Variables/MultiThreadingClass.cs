using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread

// Single Thread : Step by Step Exucute like "Sync" way
// MultiThreading : 
namespace Variables
{
    class MultiThreadingClass
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 : " + i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2 : " + i);
                if (i == 50)
                {
                    Thread.Sleep(5000);
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3 : " + i);
            }
        }

        ////////////////////////////////////// Multi Threading //////////////////////////////////
        public static void Test4()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test4 : " + i);
            }
        }
        public static void Test5()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test5 : " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread 5 is going to Sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 5 Woke Up");
                }

            }
        }
        public static void Test6()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test6 : " + i);
            }
        }
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Exucuting Thread is: " + Thread.CurrentThread.Name);
            /////// Single Thread /////
            Test1();
            Test2();
            Test3();
            /////// Multi Threading ///////
            Thread t4 = new Thread(Test4);
            Thread t5 = new Thread(Test5);
            Thread t6 = new Thread(Test6);
            t4.Start(); // start Thread
            t5.Start();
            t6.Start();
        }
    }
}