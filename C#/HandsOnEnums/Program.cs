using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEnums
{

    enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug};
    enum Color { Red, Orange, Yellow, Green, Blue, Indigo, Violet };

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine((int)Month.Jan);
            Console.WriteLine((int)Color.Violet);
            
            Console.ReadKey();

        }
    }
}
