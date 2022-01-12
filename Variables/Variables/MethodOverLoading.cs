using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    public class MethodOverLoading{
        public MethodOverLoading(){
            Console.WriteLine("Method OverLoading Constructor Called");
        }
        public void Method(){
            Console.WriteLine("1st Method OverLoading Called");
        }
        public void Method(int i){
            Console.WriteLine($"2nd Method OverLoading Called {i}");
        }
        public void Method(string name){
            Console.WriteLine($"3rd Method OverLoading Called {name}");
        }
        public void Method(int i, string name){
            Console.WriteLine($"4th Method OverLoading Called {i} {name}");
        }
        public void Method(string name, int i){
            Console.WriteLine($"5th Method OverLoading Called {name} {i}");
        }
        static void Main() { }

    }
}
