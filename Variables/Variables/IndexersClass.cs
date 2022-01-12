using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    class IndexersClass
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public IndexersClass(int Eno, double Salary, string Ename, string Dname, string Location, string Job)
        {
            this.Eno = Eno;
            this.Salary = Salary;
            this.Ename = Ename;
            this.Dname = Dname;
            this.Location = Location;
            this.Job = Job;
        }

        public object this[int index]
        { // Access index by using "index"
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Salary;
                else if (index == 3)
                    return Dname;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Job;
                return null;
            }
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Salary = (double)value;
                else if (index == 2)
                    Ename = (string)value;
                else if (index == 3)
                    Dname = (string)value;
                else if (index == 4)
                    Location = (string)value;
                else if (index == 5)
                    Job = (string)value;
            }
        }

        ///Strings Way
        public object this[string name] // Access index by using "string"
        {
            get
            {
                if (name == "Eno") //(name.ToUpper == ENO)
                    return Eno;
                else if (name == "Ename")
                    return Ename;
                else if (name == "Salary")
                    return Salary;
                else if (name == "Dname")
                    return Dname;
                else if (name == "Location")
                    return Location;
                else if (name == "Job")
                    return Job;
                return null;
            }
            set
            {
                if (name == "Eno")
                    Eno = (int)value;
                else if (name == "Salary")
                    Salary = (double)value;
                else if (name == "Ename")
                    Ename = (string)value;
                else if (name == "Dname")
                    Dname = (string)value;
                else if (name == "Location")
                    Location = (string)value;
                else if (name == "Job")
                    Job = (string)value;
            }
        }


        static void Main()
        {

        }
    }
}