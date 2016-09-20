using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class3
    {

        static void Main() { 
           int[] nums = new int[10];
           int sum = 0;

           for (int i = 0; i < 10; i++ )
           {
               nums[i] = int.Parse(Console.ReadLine());
           }

           for (int i = 0; i < 10; i++)
           {
               
               sum += nums[i];
           }

           Console.WriteLine(sum);
           Console.ReadKey();

        }
    }
}
