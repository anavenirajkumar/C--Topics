using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{

    class Costomer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }

    class CollectionsClassFour
    { // Dictionary is Collection
        static void Main()
        {


            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 1010); // <string, object> => key value, object value
            dt.Add("Ename", "Rajkumar");
            dt.Add("Job", "Manager");
            dt.Add("Salary", 25000.00);
            dt.Add("Mgrid", 1002);
            dt.Add("Phone", "8328369027");
            dt.Add("Email", "Scott@gmail.com");
            dt.Add("Dname", "Software");
            dt.Add("Location", "Hyderabad");
            dt.Add("Age", 24);

            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ": " + dt[key]);
            }


            List<Costomer> Costomers = new List<Costomer>();

            Costomer c1 = new Costomer { CustId = 101, Name = "Rajkumar", City = "Karimnagar", Balance = 25000.00 };
            Costomer c2 = new Costomer { CustId = 102, Name = "Srikanth", City = "Manakondur", Balance = 5000.00 };
            Costomer c3 = new Costomer { CustId = 103, Name = "Ajay", City = "Srinivasnagar", Balance = 2000.00 };
            Costomer c4 = new Costomer { CustId = 104, Name = "Prem", City = "Renikunta", Balance = 14000.00 };

            Costomers.Add(c1);
            Costomers.Add(c2);
            Costomers.Add(c3);
            Costomers.Add(c4);

            foreach (Costomer obj in Costomers)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }

            Console.ReadLine();


        }

    }
}