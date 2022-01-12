using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    interface IInterfaceClass{
        void Add(int a, int b); // Interfaces are predefine public        
    }
    interface IInterfaceClassTwo : IInterfaceClass{ // Inherited Interface
        void Sub(int a, int b);
    }

    interface Interface1{
        void Test1();
    }

    interface Interface2{
        void Test1();
    }
    public class ImplementationInterface : IInterfaceClassTwo, Interface1, Interface2
    {
        public void Add(int a, int b) { // public is Mandatory
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b){
            Console.WriteLine(a - b);
        }

        public void Test1(){
            Console.WriteLine("Im in Multiplaton Interface Class");
        }

        public void Test2()
        {
            Console.WriteLine("Im in Multiplaton Interface Class");
        }

        static void Main(){
            ImplementationInterface obj = new ImplementationInterface();
            obj.Add(10, 20);
            obj.Sub(20, 40);
            //obj.Test1();
            Interface1 o1; obj.Test1();
            Interface2 o2; obj.Test1();
            Console.ReadLine();
        }
    }


}


