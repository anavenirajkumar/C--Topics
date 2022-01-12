using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class LambdaExpressionsClass
    {
        static void Main()
        {
            GreetingsDelegate obj = (name) => { // => Lambda Expression
                return "Hello " + name + "Gd Evening";
            };
            string str = obj.Invoke("Rajkumar form Hyderabad");
            Console.WriteLine(str);

            // Types Delegates
            // "Func" Delegate  -> return type method
            // "Action" Delegate -> void type method
            // "Predicate" -> return type "boolean" method only for use

            // Func Delegate
            Func<int, float, double, double> obj1 = (x, y, z) => {
                return x + y + z;
            };
            double result = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            /// Action Delegate
            Action<int, float, double> obj2 = (x, y, z) => {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(100, 34.5f, 193);

            /// Predicate Delegate
            Predicate<string> obj3 = (str) => {
                if (str.Length > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool status = obj3.Invoke("Hello World");
            Console.WriteLine(status);
            Console.ReadLine();
        }
    }

}