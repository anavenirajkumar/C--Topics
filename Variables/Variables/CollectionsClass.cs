using System;
using System.Collections.Generic;
using System.Text;
using System.Collections; // Import

namespace Variables
{
    // Collections :
    // Increasing the array size
    // Inserting values into the middle
    // Deleting or Removing Values from Middle

    // Non-Generic Collections :
    // System Collections: Stack, Queue, LinkedList, SortedList, ArrayList, Hashtable

    class CollectionsClass
    {

        static void Main()
        {
            ArrayList al = new ArrayList(); // initial => 0; if add (10) after complted 10, this Auto Resizing to 20;
            Console.WriteLine(al.Capacity); // 0
            al.Add(100); // adding 
            Console.WriteLine(al.Capacity); // 4 -> If add any goes to = 4
            al.Add(200); al.Add(300); al.Add(400); // here almost 4 filled
            Console.WriteLine(al.Capacity); // 4
            al.Add(500); // im adding this almost 8 -> increasing Double
            Console.WriteLine(al.Capacity); // 8 -> // Auto Resizing or Increasing Double

            al.Insert(3, 350);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
            }

            //al.Remove(200); // removed 200
            al.RemoveAt(1); // 1 index , removed 200
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
            }
            // HashTable Takes : key,value
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Rajkumar");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("Mgrid", 1002);
            ht.Add("Phone", "8328369027");
            ht.Add("Email", "Scott@gmail.com");
            ht.Add("Dname", "Software");
            ht.Add("Location", "Hyderabad");
            ht.Add("Age", 24);

            //Console.WriteLine(ht["Email"]);
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + "  " + ht[key]);
            }
            Console.ReadLine();



        }
    }
}