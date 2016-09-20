using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenProject4._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int no = int.Parse(Console.ReadLine());
            do{
            Console.WriteLine("1. Even/Odd");
            Console.WriteLine("2. Natural Nos");
            Console.WriteLine("3. Mul table");
            Console.WriteLine(" Enter choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    if (no % 2 == 0)
                        Console.Write("Even");
                    else
                        Console.Write("Odd");
                    break;
                case 2:
                    int i = 1;
                    while (i <= no) {
                        Console.Write(i + " ");
                        i++;
                    }
                    break;
                case 3:
                    for (int k = 1; k <= 10; k++) {
                        Console.WriteLine("{0}*{1}={2}", no, k, (no*k));
                    }
                    break;
                case 4:
                    Environment.Exit(0);//close application
                    break;

                default:
                    Console.WriteLine("Enter correct choice!!");
                    break;

                    


            }
           

            }
            while (true);

        }
        
    }
}
