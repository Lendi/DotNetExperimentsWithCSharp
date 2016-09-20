using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class stringOps
    {
        static void Main(){
        double price = 12.124;
        //string s = string.Format("{0:C}, price");
        string s = string.Format("{0:F0}", price);

        Console.WriteLine(DateTime.Now);
        Console.WriteLine("{0:D}", DateTime.Now);
        Console.WriteLine("{0:d}", DateTime.Now);
        Console.WriteLine("{0:T}", DateTime.Now);
        Console.WriteLine("{0:t}", DateTime.Now);
        Console.WriteLine(s);
        Console.ReadKey();
        }
    }
}
