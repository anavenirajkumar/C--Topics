using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    public class CollectionsClass<T>
    { /// <T> => Set in Total Class TypeSafety
        public void Add(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0; dynamic indenfy runtime
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }

    class CollectionsClassThree
    {
        static void Main()
        {

            CollectionsClass<int> generic = new CollectionsClass<int>();

            generic.Add(10, 20);
            generic.Sub(10, 20);
            generic.Mul(10, 20);
            generic.Div(10, 20);

            Console.ReadLine();
        }
    }
}