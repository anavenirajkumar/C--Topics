using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    /////////////////////// Generic Colletions //////////////////////
    // *Note -> Array : "Type Safe" but "fixed Length"
    // *Note -> Collection : "Auto Resizing" but Not "Type Safe"
    // Generic Collections : "TypeSafe" and "Auto Resizing"

    class CollectionsClassTwo
    {

        public bool Compare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Compare1<T>(T a, T b)
        { // <T> => Type
            if (a.Equals(b))
            { // Equals => any Object must with Same Values
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add<T>(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0; dynamic indenfy runtime
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul<T>(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div<T>(T a, T b)
        {
            dynamic d1 = a; // Dynamic Intedous C# 4.0
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }

        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20); li.Add(30);
            li.Add(40); li.Add(50); li.Add(60);

            li.Insert(3, 100); // Adding in Index 3 = 100
            for (int i = 0; i < li.Count; i++)
            { // Count = Length
                Console.WriteLine(li[i]);
                Console.WriteLine();
            }
            li.RemoveAt(1);
            foreach (int obj in li)
            {
                Console.WriteLine(obj);
            }

            CollectionsClassTwo generic = new CollectionsClassTwo();
            bool result = generic.Compare(100, 100);
            Console.WriteLine(result);

            bool result2 = generic.Compare1<float>(12.55f, 23.56F);
            Console.WriteLine(result2);

            bool result3 = generic.Compare1<int>(12, 12);
            Console.WriteLine(result3);

            bool result4 = generic.Compare1<string>("a", "a");
            Console.WriteLine(result4);

            generic.Add<int>(10, 20);
            generic.Sub<int>(10, 20);
            generic.Mul<int>(10, 20);
            generic.Div<int>(10, 20);

            Console.ReadLine();
        }

    }
}