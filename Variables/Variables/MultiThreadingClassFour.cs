using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; // import Thread

namespace Variables
{
    class MultiThreadingClassFour
    {

        public void Display()
        {
            lock (this) // Example : Telephone Booth -> Step by Step way
            {
                Console.WriteLine("CSharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language");
            }
        }

        static void Main()
        {
            MultiThreadingClassFour f = new MultiThreadingClassFour();
            Thread t1 = new Thread(f.Display);
            Thread t2 = new Thread(f.Display);
            Thread t3 = new Thread(f.Display);
            //t1.Start(); 
            t1.Start(); t2.Start(); t3.Start();
            Console.ReadLine();
        }
    }
}