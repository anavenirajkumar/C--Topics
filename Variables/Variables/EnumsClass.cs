using System;
namespace Variables
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednessay = 3,
        Thusday = 4
    }
    class EnumsClass{  // ???

   
        static void Main()
        {
            Days m = Days.Tuesday;
            Console.WriteLine((int)m);

            Console.BackgroundColor = ConsoleColor.Blue; // for Background Console Color
            Console.WriteLine("Enums Class");

           /* foreach (int i in Enum.GetValues(typeof(Days)));
            Console.WriteLine(i);

            foreach (string s in Enum.GetNames(typeof(Days))) ;
            Console.WriteLine(s);*/
            Console.ReadLine();

        }
    }
}