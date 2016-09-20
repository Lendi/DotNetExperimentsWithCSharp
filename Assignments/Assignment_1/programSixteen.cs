using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class programSixteen
    {
        static void Main(string[] args)
        {
           int[] nums = new int [10];
           int mini = 0, sum = 0;
            for(int i = 0; i < 10; i++){

                nums[i] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < 10; i++)
            {
                sum = sum + nums[i];               
            }

            Console.WriteLine("Sum:"+sum);
            Console.WriteLine("Avg:" +(sum/10));


            for(int i = 1; i < 10; i++){
                for(int j = 0; j < i; j++){
                    mini = nums[j];
                    if(mini < nums[i]){
                        mini = nums[i];
                    }
                }
                Console.WriteLine("Minimum:" +mini);
            Console.ReadKey();
        }
    }

    }
}
