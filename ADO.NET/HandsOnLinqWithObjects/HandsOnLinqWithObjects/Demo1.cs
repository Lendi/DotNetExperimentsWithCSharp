using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinqWithObjects
{
    class Demo1
    {
        static void Main() {
            string[] email = { "yahoo.com", "yahoo.co.in", "msn.com", "gmail.com", "msn.in" };
            var res = from f in email where f.EndsWith(".com") select f;
            foreach (var v in res)
                Console.WriteLine(v);
        
        }
    }
}
