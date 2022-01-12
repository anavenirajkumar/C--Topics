using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Variables
{

    class CollectionsClassFive : IComparable<CollectionsClassFive>
    { // Interface for Sorting "Sid" -> 101,102,103,104
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }


        public static int CompareNames(CollectionsClassFive S1, CollectionsClassFive S2)
        {
            return S1.Name.CompareTo(S2.Name);
        }
        static void Main()
        {
            CollectionsClassFive s1 = new CollectionsClassFive { Sid = 104, Name = "Rajkumar", Class = 15, Marks = 90 };
            CollectionsClassFive s2 = new CollectionsClassFive { Sid = 103, Name = "Srikanth", Class = 10, Marks = 80 };
            CollectionsClassFive s3 = new CollectionsClassFive { Sid = 101, Name = "Ajay", Class = 12, Marks = 70 };
            CollectionsClassFive s4 = new CollectionsClassFive { Sid = 102, Name = "Prem", Class = 18, Marks = 95 };

            List<CollectionsClassFive> Students = new List<CollectionsClassFive>() { s1, s2, s3, s4 };
            //CompareStudents obj = new CompareStudents(); // For Marks Soring Wise Instance
            //Students.Sort(obj); Method 1 // Sort Method Works Only Using Interface; and passing "obj" for Marks Sorting wise
            //Students.Sort(1, 3, obj);  Method 2 // index 1, index 3 are NoT Sorted, remaining objects Sorted
            //Students.Reverse();
            Comparison<CollectionsClassFive> obj = new Comparison<CollectionsClassFive>(CompareNames); // For Sorting Names => a,b,c,d....z
            Students.Sort(obj);

            foreach (CollectionsClassFive stu in Students)
            {
                Console.WriteLine(stu.Sid + " " + stu.Name + " " + stu.Class + " " + stu.Marks);
            }


        }

        public int CompareTo(CollectionsClassFive other)
        { // Sorting Method with Interface => 101,102,103,104
            if (this.Sid > other.Sid)
            {
                return 1; // if you want reverce: -1
            }
            else if (this.Sid < other.Sid)
            {
                return -1;  // if you want reverce: 1
            }
            else
            {
                return 0;
            }
        }
    }

    class CompareStudents : IComparer<CollectionsClassFive> // IComparer
    {
        public int Compare(CollectionsClassFive x, CollectionsClassFive y)
        {
            if (x.Marks > y.Marks)
            {
                return 1;
            }
            else if (x.Marks < y.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}