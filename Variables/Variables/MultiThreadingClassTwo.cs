using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread


namespace Variables
{
    class MultiThreadingClassTwo
    {
        static void Test(object max)
        { // Parametarized Thread : take "object"
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test : " + i);

            }
        }
        static void Main()
        {
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //ThreadStart obj = delegate() { Test(); }
            // ThreadStart obj = () => Test(); // Lambda Expression

            Thread t1 = new Thread(Test);
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            t1.Start(50); // pass value


            Console.ReadLine();

        }
    }

}