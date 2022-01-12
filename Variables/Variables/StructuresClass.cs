using System;
namespace Structures {

    struct StructuresClass{ // struct keyword -> use structures for represemnting  smaller value Data; eaxmple : Int32, float, bool, are Structures => define with this and Right Click and : "Go to Defenation"
                            //public float -> Test Now
                            // Not Require : = new StructuresClass
                            // Intitilization works; but Initiolization and properties not works
                            // Structures can't Support Inheritance by Other Structures
        int i;              // interfaces are Support in Structures

        public StructuresClass(int i) { // Constructor
            this.i = i;
        }
        public void Display()
        {
            Console.WriteLine("Display Method in Structures Class: " + i);
        }
       static void Main()
        {
            StructuresClass structure; // *
            structure.i = 10;// *
            structure.Display();
 
            StructuresClass obj = new StructuresClass();
            obj.Display();

            StructuresClass objtwo = new StructuresClass(30);
            objtwo.Display();
            Console.WriteLine();
        }

    }
}