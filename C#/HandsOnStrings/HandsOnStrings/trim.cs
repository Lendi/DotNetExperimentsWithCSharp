using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class trim
    {
        static void Main() {
            string name = "  aslg";
            name = name.Trim();

            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
