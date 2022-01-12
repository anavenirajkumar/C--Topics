using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    public class DevidedByOddNoException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attemplted to divide by odd Number";
            }
        }

    }
    class ExceptionHandlingClassTwo
    { // run with command prompt this file => csc ExceptionHandlingClassTwo.cs
        static void Main()
        {
            Console.WriteLine("Enter 1st Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 > 0)
            { // 100 / 0 , 100 /5
                //throw new ApplicationException("Divisor value can't be odd no.");
                throw new DevidedByOddNoException();
            }
            int z = x / y;
            Console.WriteLine("The Result is: " + z);
            Console.WriteLine("End of the Program");
        }
    }
}