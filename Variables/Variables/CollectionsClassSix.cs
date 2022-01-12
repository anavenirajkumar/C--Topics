using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Variables
{

    public class Employee
    {  // Enumarable Interface
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    public class Organization : IEnumerable
    { // IEnumerable is Interface, that is implementaded by all the collection Classes; every collection has a GetEnumerator because of the that method only we can use only "foreach" loop on the collection
        List<Employee> Employees = new List<Employee>();
        public void Add(Employee Emp)
        {
            Employees.Add(Emp);
        }

        public int Count
        {
            get { return Employees.Count; }
        }

        public Employee this[int index]
        {
            get
            {
                return Employees[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            //return Employees.GetEnumerator();
            return new OrganizationEnumerator(this);
        }
    }

    public class OrganizationEnumerator : IEnumerator
    {  // Costom Enumarator
        Organization OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;
        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1; // before

        }
        public object Current
        {  // Current Record
            get
            {
                return CurrentEmployee;
            }
        }
        public bool MoveNext()
        {
            if (++CurrentIndex >= OrgColl.Count)
                return false;
            else
                CurrentEmployee = OrgColl[CurrentIndex]; // index 0
            return true;
        }

        public void Reset()
        {

        }
    }

    class CollectionsClassSix
    {
        static void Main()
        {
            //List<Employee> Employees = new List<Employee>();
            Organization Employees = new Organization();
            Employees.Add(new Employee { Id = 101, Name = "Rajkumar", Job = "Software Developer", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Srikanth", Job = "Accountant", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Ajay", Job = "Doctor", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 104, Name = "Siddu", Job = "Driver", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Prem", Job = "BusinessMan", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 106, Name = "Sathi", Job = "Teacher", Salary = 15000.00 });

            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.Id + " :" + emp.Name + " " + emp.Job + "" + emp.Salary);
            }

        }
    }
}