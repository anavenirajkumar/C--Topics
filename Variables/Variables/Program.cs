
// Data Types : int , string, double, float, char, bool, long, 
// if you Look Only Every Class Program Output => Right Click Solution Expolorer "Properties" "Application,General" "Startup object" in Select Choose Class Name

using System;

namespace Variables
{
   public class Program{

        ///////////////// Access Specifiers ////////////////////
        public void Test1()
        {
            Console.WriteLine("Public Method Method");
        }
        private void Test2() // Private
        {
            Console.WriteLine("Private Method");
        }
        internal void Test3()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test4()
        {
            Console.WriteLine("Protected Method Method");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Protected Internal Method Method");
        }
       /// /////////////////////////////////////////////////////////

       public int rechange = 23; // Non-Static Variable => for Access Create a Instant Object
       public string raj = "Fulll Stack Developer";  // Non-Static Variable  => for Access Create a Instant Object
       static string kumar = "MEAN Stack Developer"; // Static Variable and  { in body also  } => Direct Access
       const int constact = 3338; // using "const" keyword "No Need Creation Object, it Access Direct"
        // readonly :  only access constructor initilization and direc access

        static void Main(string[] args)
        {
            int myNum = 10; // Integer Type
            myNum = 20;
            Console.WriteLine(myNum); // 20;

            string name = "Rajkumar"; // String Type 
            Console.WriteLine(name); // Rajkumar

            char myLetter = 'D'; // Character Type
            Console.WriteLine(myLetter); // D

            bool myBool = true; // Boolean Type
            Console.WriteLine(myBool); // true

            double myDoubleNum = 5.99D; // Double Type
            Console.WriteLine(myDoubleNum);// 5.99D

            float myFloat = 5.75F; // Float Type
            Console.WriteLine(myFloat); // 5.75F


            int num1 = 10;
            int num2 = 20;
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            int x = 5, 
            y = 6,
            z = 50;
            Console.WriteLine(x + y + z);

            string firstname = "Anaveni";
            string lastname = "Rajkumar";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            // instant object
            Program r = new Program();
            r.rechange = 99; // before 23 after 99
            Console.Write(r.rechange);  // 99
            Console.WriteLine(r.raj); // Full Stack Developer
            Program r1 = r; // Assign Reference to Reference
            Console.WriteLine(r1.rechange); //99

            Console.WriteLine(constact);// this not Static variable, and Non-Static Variablethis is "const" Keyword

            // static object is Direct Call
            Console.WriteLine(kumar); // MEAN Stack Developer

            ///////////////// Access Specifiers ////////////////////
            // 1) public 2) private 3) protected 4)internal 5)protected internal

            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
            Console.WriteLine("Im in Acess Modifiers");

            ////////////////////// Inheritance /////////////////////////

            ////////////////////// Method Overloading //////////////////
            MethodOverLoading lo = new MethodOverLoading();
            lo.Method();
            lo.Method(60);
            lo.Method("Laxminarsaiah");
            lo.Method(61, "Anaveni Laxminarsaiah");
            lo.Method("Anaveni Laxminarsaiah", 62);

            //////////////////// Method OverRiding /////////////////////
            /* MethodOverRiding ride = new MethodOverRiding();
             ride.Riding();
             ride.RidingShow();*/


            /////////////////////////// Operator OverLoading /////////////////////////
            OperatorOverLoading adding = new OperatorOverLoading(20,28,16,14);
            OperatorOverLoading adding2 = new OperatorOverLoading(10, 8, 6, 4);
            OperatorOverLoading adding3 = adding + adding2;
            OperatorOverLoading adding4 = adding - adding2;

            Console.WriteLine(adding);
            Console.WriteLine(adding2);
            Console.WriteLine(adding3);
            Console.WriteLine(adding4);

            ////////////////////////// Abstract Classes /////////////////////////////
            /* AbstractClass myPig = new AbstractClass();  // Create a Pig object
             myPig.Add(70,20);
             myPig.Sub(45,35);*/

            //Animal ab = new Animal();
            AbstractClass abs = new AbstractClass(12.67,56.78);
            Circle abst = new Circle(45.67);
            Cone c = new Cone(34.98,12.98);
            Console.WriteLine("Area of Rectangle:" + abs.GetArea());
            Console.WriteLine("Area of Rectangle:" + abst.GetArea());
            Console.WriteLine("Area of Rectangle:" + c.GetArea());

            //////////////////////// Interfaces ////////////////////////////

            // Multiple Interfaces
            /*  MultipleInterfacesClass Obj = new MultipleInterfacesClass();
              Obj.Test();*/

            /////////////////////// Structures ////////////////////////////


            /////////////////////// Properties ///////////////////////////

            PropertiesClass prop = new PropertiesClass(101,false,"Rajkumar",20000.00, Cities.Karimnagar,"Telanagana");
            Console.WriteLine("Costomer A/C No: " + prop.CustomerId); // Get Value
            prop.CustomerId = 3338; // Set Value
            Console.WriteLine("Costomer A/C No: " + prop.CustomerId);
            if (prop.Status == true){
                Console.WriteLine("Costomer A/C  Active: " + prop.Status);
            }
            else{
                Console.WriteLine("Costomer A/C  In-Active: " + prop.Status);
            }
            prop.CostomerName += "Anaveni Rajkumar";
            Console.WriteLine("Costomer Name Modified: " + prop.CostomerName);

            prop.Status = true;
            prop.Balance = 10000.00;//if Status is "true" Deposit Money Other wise Previous Money Data
            Console.WriteLine("Added Balance: " + prop.Balance);
            prop.Balance -= 10000.00; // Im Withdraw My Money
            Console.WriteLine("Withdraw Balance: " + prop.Balance);
            if (prop.Status == true)
            {
                Console.WriteLine("Costomer A/C  Active: " + prop.Status);
            }
            else
            {
                Console.WriteLine("Costomer A/C  In-Active: " + prop.Status);
            }

            prop.Balance -= 19000;
            Console.WriteLine("Withdraw Balance is " + prop.Balance);

            Console.WriteLine("Your Branch is " + prop.City);
            prop.City = Cities.Hyderabad; // Not Acceble 
            Console.WriteLine("Your Branch is " + prop.City);
            //prop.State = "Andhrapradesh";
            Console.WriteLine("Your State is " + prop.State);
            Console.WriteLine("Your Country is " + prop.Country);



            //Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////// Indexers ///////////////////////////////////////////////////

            Console.WriteLine("Im Learning C#");
            IndexersClass ind = new IndexersClass(1001, 10000.00, "Scott", "Sales", "Software", "Hyderabd");
            Console.WriteLine("Eno:" + ind[0]);
            Console.WriteLine("Ename:" + ind[1]);
            Console.WriteLine("Job:" + ind[2]);
            Console.WriteLine("Salary:" + ind[3]);
            Console.WriteLine("Dname:" + ind[4]);
            Console.WriteLine("Location:" + ind[5]);

            ind[0] = 3338;
            Console.WriteLine("Eno:" + ind[0]);
            ind[1] = 20000.00;
            Console.WriteLine("Ename:" + ind[1]);
            ind[2] = "Anaveni Rajkumar";
            Console.WriteLine("Job:" + ind[2]);
            ind[3] = "Anaveni Rajkumar";
            Console.WriteLine("Salary:" + ind[3]);
            ind[4] = "Anaveni Rajkumar";
            Console.WriteLine("Dname:" + ind[4]);
            ind[5] = "Karimnagar";
            Console.WriteLine("Location:" + ind[5]);


            //////////// String Way //////////////
            Console.WriteLine("Eno:" + ind["Eno"]);
            Console.WriteLine("Ename:" + ind["Ename"]);
            Console.WriteLine("Job:" + ind["Job"]);
            Console.WriteLine("Salary:" + ind["Salary"]);
            Console.WriteLine("Dname:" + ind["Dname"]);
            Console.WriteLine("Location:" + ind["Location"]);

            ind["Eno"] = 101;
            Console.WriteLine("Eno:" + ind["Eno"]);

            ind["Ename"] = "Tally";
            Console.WriteLine("Ename:" + ind["Ename"]);

            ind["Job"] = "SDNJ";
            Console.WriteLine("Job:" + ind["Job"]);

            ind["Salary"] = 5000.00;
            Console.WriteLine("Salary:" + ind["Ename"]);


            ind["Dname"] = "Tally";
            Console.WriteLine("Job:" + ind["Salary"]);

            ind["Location"] = "Mumbai";
            Console.WriteLine("Location:" + ind["Location"]);
            ////////////////////////////////////////////////////////// Delegates ///////////////////////////////////////////////////
            DelegatesClass del = new DelegatesClass();
            del.AddNumbers(10, 20);

        }
    }
}