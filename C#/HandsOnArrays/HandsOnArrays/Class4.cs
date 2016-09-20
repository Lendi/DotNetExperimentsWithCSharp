using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class4
    {
        static void Main() {

            char[] alphabets = new char[] {'a', 'e', 'i', 'o', 'b', 'r', 'l', 'u' };

            foreach (char v in alphabets)
            {
                if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                {
                    Console.WriteLine(v);

                }
            }
            Console.ReadKey();
        }
    }
}
