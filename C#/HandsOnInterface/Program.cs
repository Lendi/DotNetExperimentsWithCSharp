using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterface
{
    interface Ishape {
        void Shape();
        double Area();
    
    }

    class Circle : Ishape {

        public void Shape()
        {
            Console.WriteLine("I'm a circle");
        }

        public double Area()
        {
            return 0.0;
        }

       
       
    }

    class Square : Ishape {

        public void Shape()
        {
            Console.WriteLine("I'm a square");
        }

        public double Area()
        {
            return 0.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           // Circle c = new Circle();
            //c.Shape();
            //c.Area();
            //Square s = new Square();
            //s.Area();
            //s.Shape();

            //access only interface members
            Ishape icircle = new Circle();
            icircle.Area();
            icircle.Shape();
            Ishape isquare = new Square();
            isquare.Area();
            isquare.Shape();
        }
    }
}
