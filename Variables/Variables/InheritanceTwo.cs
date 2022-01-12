using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
     class InheritanceTwo:Inheritance{ // import Inheritance
        public InheritanceTwo() : base(99){ // Set Value to Parent Class Constructor
            Console.WriteLine("Im a Child Constructor");
        }
        public void Test3(){
            Console.WriteLine("Method 3");
        }
        static void Main(){
            InheritanceTwo c = new InheritanceTwo();
            c.Test1();
            c.Test2();
            c.Test3();
            Inheritance raj;
            InheritanceTwo kumar = new InheritanceTwo();
            raj = kumar;
            raj.Test1(); 
            raj.Test2();
            Console.WriteLine(raj.GetType()); // GetType means Find Class

        }
    }
}
