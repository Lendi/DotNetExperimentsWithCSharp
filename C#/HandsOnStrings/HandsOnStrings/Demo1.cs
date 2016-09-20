using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo1
    {
        static void Main() { 
        string s1 = "Welcome";
        string s2 = "welcome";
        if (string.Compare(s1, s2, true) == 0)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

        if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
        Console.ReadKey();
        }
    }
}
