using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class8
    {
        static void Main() {
            int[,] a = new int[3, 2];
            a[0, 0] = 10;
            a[0, 1] = 20;
            a[1, 0] = 30;
            a[1, 1] = 40;
            a[2, 0] = 50;
            a[2, 1] = 60;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(a[i, j] + " ");
                
                }
                Console.WriteLine();
            
            }
            Console.ReadKey();
        }
    }
}
