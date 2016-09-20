using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinqWithObjects
{
    class Demo5
    {
        static void Main() {
            int[] a = { 12, 23, 34, 45, 56, 33, 67, 78,78 };
            var res = a.Where(i => i % 2 == 0);// inside where we're passing a Lambda expression
            //res = a.OrderBy(i => i);
            //res = a.OrderBy(i => i % 2 == 0);
            //res = a.OrderByDescending(i => i);
            foreach (int k in res)
                Console.WriteLine(k);
        }
    }
}
