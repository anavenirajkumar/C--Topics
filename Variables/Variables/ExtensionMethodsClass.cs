using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
    static class ExtensionMethodsClass
    { // ???
        public static void Extension(this ExtensionMethodsClassTwo e)
        { // parameter is for only binding other Class
            Console.WriteLine("Im in Extension Methods Class");
        }

        static void Main()
        {
            ExtensionMethodsClassTwo ex = new ExtensionMethodsClassTwo();
            ex.Extension();
            ex.ExtensionMethodTwo();
        }
    }
}