using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class programSeventeen
    {
        static void Main() {
            int count = 0;
        String xyz = Console.ReadLine();
        foreach (char k in xyz) {
            if (k != '\0')
            {
                count = count + 1;
            }
            else
                ;
        }



        Console.ReadKey();
        }
    }
}
