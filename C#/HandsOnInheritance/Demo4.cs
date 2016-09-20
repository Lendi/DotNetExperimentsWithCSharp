using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Demo4
    {
        static void Main() {
            DateTime d1;
            DateTime d2;
            d1 = DateTime.Parse("28.08.2016");
            d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            if (d1.ToShortDateString() == d2.ToShortDateString()) {
                Console.WriteLine("Happy Birthday!!! :) ");
            }
            Console.WriteLine(t.Days);
        }
    }
}
