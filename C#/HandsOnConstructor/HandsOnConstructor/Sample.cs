using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Sample
    {
        int i, j;
        public Sample() {

            i = 10;
            j = 20;
        }
        public void Show() {
            Console.WriteLine("{0} {1}", i, j);
        }

        static void Main() {
            Sample s = new Sample();
            s.Show();
            Sample s1 = new Sample();
            s1.Show();
            Sample s2 = new Sample();
            s2.i = 100;
            s2.j = 200;
            s2.Show();

            Console.ReadKey();
        }
    }
}
