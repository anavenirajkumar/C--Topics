using System;
using System.Collections.Generic;
using System.Text;


namespace Variables // Delegates : Match void type, and parameters 
{ // Methods and Delegates Almost Same but in Delegates we Declare "delegate" 
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str); // Define a Delegate

    public delegate void RectDelegate(double Width, double Height);
    class DelegatesClass
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello" + name;
        }

        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of Rectangle", Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of Rectangle", 2 * (Width * Height));
        }

        static void Main()
        {
            DelegatesClass del = new DelegatesClass(); // Create a Instance Object
            del.AddNumbers(30, 40); // 70 Normal Method

            AddDelegate delAdd = new AddDelegate(del.AddNumbers);//Delegate Method
            delAdd(30, 40); // 70 Delegate Method 

            SayDelegate delSay = new SayDelegate(DelegatesClass.SayHello); // Delegate Method
            string str = delSay("Rajkumar"); // Delegate Method  or delSay.Invoke("Rajkumar");

            //SayHello("Rajkumar"); // Static Method Calling
            Console.WriteLine(str);

            del.GetArea(12.34, 56.78); // Normal Way
            del.GetPerimeter(12.34, 56.78); // Normal Way



            RectDelegate rect = del.GetArea;
            rect += del.GetPerimeter; // Using Delegates

            rect.Invoke(12.34, 56.78); // Using Delegates
            Console.WriteLine();
            rect.Invoke(47.87, 34.89);

        }
    }
}