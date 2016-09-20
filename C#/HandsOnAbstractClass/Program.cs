using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractClass
{
    abstract class Shape { 
    //abstract method
        public abstract void Area();
        public void Type()
    {
        Console.WriteLine("Im a 2d shape");
    }
    }
        class Rectangle : Shape {

            private int l, w;
            public Rectangle(int l, int w) {
                this.l = l;
                this.w = w;
            
            }
            
            public override void Area()
            {
                Console.WriteLine("Area of rect :" + (l*w) );
            }
            

        }

        class Circle : Shape {

            private double r;

            public Circle(double r) {
                this.r = r;
            }

            public override void Area()
            {
                Console.WriteLine("Area of Circle :" + Math.PI * r*r);
            }
        
        }

     

    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle(4, 3);
            Shape s1 = new Circle(12);
            s.Type();
            s.Area();
            s1.Type();
            s1.Area();

        }
    }
}
