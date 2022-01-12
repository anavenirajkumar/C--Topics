using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables{
     class AcceccSpecifiers : Program { // Inherited by Program Class 
        static void Main(){
            AcceccSpecifiers access = new AcceccSpecifiers();
            access.Test1(); // public 
            // access.Test2(); Private Cannot Acces  Outside Class
            access.Test3(); // internal
            access.Test4(); // protected
            access.Test5(); // pretected internal
            

        }
    }
}
