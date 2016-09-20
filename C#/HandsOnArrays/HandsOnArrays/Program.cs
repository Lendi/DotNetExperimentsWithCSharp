using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] {00, 11, 22, 33, 44 };
            
            foreach (int k in a) {
                Console.WriteLine(k);
            }


            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine(a[i]);
            }


                Console.ReadKey();
        }
    }
}
