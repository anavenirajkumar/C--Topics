using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
     class Inheritance {
        public Inheritance(int i){
            Console.WriteLine($"Im a Parent Constructor {i}");
        }
            public void Test1() {
                Console.WriteLine("Method 1");
            }
        public void Test2() {
            Console.WriteLine("Method 2");
        }
    }
}
