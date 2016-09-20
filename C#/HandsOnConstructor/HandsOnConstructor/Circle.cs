using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Circle
    {
        static double pi;
        double rad;


        public Circle(double rad) {
            this.rad = rad;
        }


        static Circle() {
            pi = 3.14; 
        
        }
        

        public void Area() {
            Console.WriteLine("Area for radius {0} is {1}", rad, pi*rad*rad);
        }


        static void Main() {
            Circle c1 = new Circle(12.2);
            Circle c2 = new Circle(3);
            Circle c3 = new Circle(45.567);
            c1.Area();
            c2.Area();
            c3.Area();
        }
    }
}
