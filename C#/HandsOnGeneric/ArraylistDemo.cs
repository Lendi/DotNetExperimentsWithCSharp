using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGeneric
{
    class ArraylistDemo
    {
        static void Main() {

            ArrayList a1 = new ArrayList() { 2, 3, 6, 7};

            ArrayList a3 = a1;

            a1.Add(12);

            ArrayList a2 = (ArrayList)a1.Clone();
            a1.Add(14);

            foreach (int k in a2)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
