using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Calculate
    {
        public void Add(int a, int b) {
            Console.WriteLine("Addition: " + (a + b));
        
        }

        public void Greet(String name) {
            Console.WriteLine("Hello" + name);
        }

        public int Square(int i) {
            return i * i;
        }

        public void Mul(int a, int b = 10) {
            Console.WriteLine("Multiplication " + (a * b));
        }

        static void Main() {
            Calculate obj = new Calculate();
            obj.Add(12, 23);
            obj.Greet("Lendi");
            int k = obj.Square(12);
            Console.WriteLine(k);
            Console.WriteLine(obj.Square(23));
            obj.Mul(12);
            obj.Mul(12, 34);
            Console.ReadKey();
        }
        
    }
}
