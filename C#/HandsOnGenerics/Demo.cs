using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenerics
{
    class Test<T> {
        T a;
        T b;

        int c;
        public void Accept(T i, T j, int k) {
            a = i;
            b = j;
            c = k;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            foreach()
        }
    
    }
    class Demo
    {
        static void Main() {

            Test<string> t1 = new Test<string>();
            t1.Accept("hele", "ping", 1234);

            
        }
    }
}
