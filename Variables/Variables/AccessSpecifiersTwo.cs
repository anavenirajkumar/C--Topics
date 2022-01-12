using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
    public class AccessSpecifiersTwo{
        static void Main(){
            Program p = new Program();
            Console.WriteLine("Im in AccessSpecifiersTwo Class");
            p.Test1(); // Public Method
            p.Test3(); // Internal Method
            p.Test5(); // Preotected Internal Method
            Console.ReadLine();
        }
    }
}
