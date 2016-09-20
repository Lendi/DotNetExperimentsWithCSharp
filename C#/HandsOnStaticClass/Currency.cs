using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStaticClass
{
   static class Currency
    {
       private static double dp;
       static Currency()
       {
           dp = 67.8;
       }
       public static double RTD(double rupees)
       {
           return rupees / dp;
       }
       public static double DTR(double doller)
       {
           return dp * doller;
       }
        static void Main(string[] args)
        {
            Console.WriteLine("dollers {0:F2}", Currency.RTD(100000));
        }
    }
}
