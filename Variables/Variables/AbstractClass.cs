using System;

namespace Variables{
    // Abstract class
   public abstract class Animal   {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
        // Abstract method (does not have a body)
       /* public abstract void Add(int x, int y);
        public abstract void Sub(int x, int y);
        public void sleep(){
            Console.WriteLine("Im Abstract Parent");
        }*/

    
    }




    // Derived class (inherit from Animal)
    class AbstractClass : Animal {
        public AbstractClass(double Width, double Height) {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea() {
          return Width * Height;
        }
        static void Main() { }
      /*  public override void Add(int x, int y)
        {
            Console.WriteLine("Im Adding");
            Console.WriteLine(x + y);
        }
        public override void Sub(int x, int y)
        {
            Console.WriteLine("Im Subs");
            Console.WriteLine(x - y);
        }*/

       }
        public class Circle : Animal{
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }

        public override double GetArea(){
            return Pi * Radius * Radius;
        }
    }

        public class Cone : Animal{
            public Cone(double Radius, double Height){
                this.Radius = Radius;
                this.Height = Height;
            }
        public override double GetArea(){
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    }