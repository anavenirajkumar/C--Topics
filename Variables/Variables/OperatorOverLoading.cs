using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    public class OperatorOverLoading
    {

        int a, b, c, d; // IntialLization
        public override string ToString(){ // Every Class has a Predefine Object so Im Overriding String to Numbers
            return a + "" + b + "\n" + c + "" + d + "\n";
        }
        public OperatorOverLoading(int a, int b, int c, int d){
            this.a = a; this.b = b; this.c = c; this.d = d;
        }

        public static OperatorOverLoading operator +(OperatorOverLoading obj1, OperatorOverLoading obj2){
            OperatorOverLoading obj = new OperatorOverLoading(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
                return obj;
        }
        public static OperatorOverLoading operator -(OperatorOverLoading obj1, OperatorOverLoading obj2)
        {
            OperatorOverLoading obj = new OperatorOverLoading(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
        static void Main(){

        }
    }
}
