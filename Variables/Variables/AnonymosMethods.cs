using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    public delegate string GreetingsDelegate(string name); // return type
    class AnonymosMethods
    {
        /*        public static string Greetings(string name) {
                    return "Hello " + name + " Very Good Morning";
                }*/

        static void Main()
        {
            //Greetings("Rajkumar");
            GreetingsDelegate obj = delegate (string name) { // Anonymos Method using "delegate" keyword
                return "Hello " + name + " Very Good Morning";
            };
            string str = obj.Invoke("Rajkumar");
            Console.WriteLine(str);
        }
    }
}