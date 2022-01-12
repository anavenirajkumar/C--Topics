using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    public class MethodOverRiding{
        public void Show(){
            Console.WriteLine("Im Parent Show Method Called");
        }
        public virtual void Test(){ // Overridable or Permition to Child
            Console.WriteLine("Im Parent Test Method Called");
        }

        public  void DataHiding(){
            Console.WriteLine("Im Parent DataHiding Method");
        }
       
    }
    class MethodRiding : MethodOverRiding{ // Inherited Parent
       // OverLoading Parent's Show Method in Child Class
        public void Show(int i){ 
            Console.WriteLine($"Child Show Method is Called {i}");
        }
        // OverRiding Parent's Test Method in Child Class
        public override void Test() { // Overriding or Re Implementing
            Console.WriteLine("Child's Test Method Is Called");
        }
        // DataHiding Method/ Shadowing => Method Overrriding and DataHiding  mostly Same Changing Data or Re Implementing 
        public new void DataHiding(){ // new keyword removes Just Compile Warnings Only
            Console.WriteLine("Im Child DataHiding Method");
        }
        static void Main(){
            MethodRiding riding = new MethodRiding();
            riding.Show();
           // riding.Test();
            riding.Show(99);// OverLoading in Child Class
            riding.Test(); // OverRiding in Child Class with Permition
            riding.DataHiding(); // Without Permition

            /*MethodOverRiding parent = new MethodOverRiding();
            parent.Show();
            parent.Test();
            parent.DataHiding();*/

        }
    }
}
