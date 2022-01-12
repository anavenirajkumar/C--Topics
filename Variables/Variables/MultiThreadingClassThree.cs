using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread

namespace Variables
{
    class MultiThreadingClassThree
    {

        static void Test1()
        {
            Console.WriteLine("Thread1 is Started");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test 1 : " + i);
                Thread.Sleep(1000);
                Console.WriteLine("Thread1 is existing");
            }
        }

        static void Test2()
        { // Parametarized Thread : take "object"
            Console.WriteLine("Thread 2 is Started");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test  2 : " + i);
                Console.WriteLine("Thread2 is existing");

            }
        }

        static void Test3()
        {
            Console.WriteLine("Thread 3 is Started");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test 3 : " + i);
                Console.WriteLine("Thread3 is existing");

            }
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join(); // Join Method // t1.Join(3000);
            Console.WriteLine("Main Thread Exist");
            Console.ReadLine();

        }

    }
}


