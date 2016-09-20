using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class10
    {
        static void Main() {
            int[][,] ja = new int[3][,];
            ja[0] = new int[,] {{1, 2}, {3, 4}, {5,8}};
            ja[1] = new int[,] {{6,7} ,{7,3}, {8,6} };
            ja[2] = new int[,] { {9,1}, {10,9}, {44, 55}, {11, 66}, {55, 99} };

            for (int i = 0; i < ja.Length; i++) {
                foreach (int k in ja[i]) {
                    Console.Write(k + " ");
                
                }
                Console.WriteLine();
            
            }
            Console.ReadKey();
        }
    }
}
