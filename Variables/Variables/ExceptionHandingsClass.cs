using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class ExceptionHandingsClass
    { // try , catch, finally
        /* try{
            runtime errors, statements does't require exucute errors occured
         }
         catch { 
           statements which should exucute oly when there is a runtime error
         }
         finally {
          No Errors in Program Exucute, if any Errors in Program Exucute; "Finally" Is Must Exucute
         }
         */

        static void Main()
        {
            // Example : one Ball, one Glass if u hit the ball to glass Glass is Break; But if u hitting time someone was "Catch" the ball but Glass Never Breaks;

            try
            {
                Console.WriteLine("Enter 1st Number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {  // for finally
                    return;
                }
                int z = x / y; // 1) 100 / 0 2)  100 / y 3) 100 / 777777777777777777777777777777
                Console.WriteLine("The Result is: " + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Input Must be Numaric Value");
            }
            catch (Exception ex)
            { // default
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Im Compulsary Exucute");
            }
            Console.WriteLine("End of the Program");

        }
    }
}