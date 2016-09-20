using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinqWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 34, 45, 56, 67, 78};
            //var variables are implicitly local variables
            //var can take int, float, double etc
            var res = from k in a where k % 2 != 0 select k;//resultset is an array
            res = from k in a where k > 30 select k;
            a[0] = 89;
            var res1 = from k in a
                       where k > 40 && k % 2 == 0
                       select k;
            //sorting data
            var res2 = from i in a orderby i select i;
            var res3 = from i in a orderby i descending select i;
            foreach (int k in res3)
                Console.WriteLine(k);
        }

    }

}
