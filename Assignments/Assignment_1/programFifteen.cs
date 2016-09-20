using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class programFifteen
    {
        static void Main() {

            int[] setOfNum = new int[5];

            for (int i = 0; i < 5; i++) {
               setOfNum[i] =  int.Parse(Console.ReadLine());
            }
            Array.Sort(setOfNum);


            Console.WriteLine("\n Smallest number:" +setOfNum[0]);
                Console.ReadKey();            

        }

    }
}
