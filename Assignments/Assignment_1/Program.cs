using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class programOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }

    }
    class programTwo
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.ReadKey();
        }

    }

    class programThree
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }



    class programFour
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            Console.WriteLine("Odd");
        }
    }




    class programFive
    {
        static void Main(string[] args)
        {
            int evencount = 0, oddcount = 0;
            int t = int.Parse(Console.ReadLine());
            int[] nums = new int[t];

            for (int i = 0; i < t; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < t; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evencount++;
                }
                else
                    oddcount++;

            }

            Console.WriteLine("Evens = {0} Odds = {1} ", evencount, oddcount);
            Console.ReadKey();

        }
    }








    class programSix
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            Console.WriteLine("Odd");
        }
    }





    class programEight
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("{0}", i * i);
            }
            Console.ReadKey();
        }
    }



    class programNine
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("{0}", i * i);
            }
            Console.ReadKey();
        }
    }


    class programTen
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("{0}", i * i);
            }
            Console.ReadKey();
        }
    }


    class programTwelve
    {
        static void Main(string[] args)
        {

            int d = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", d, i, (d * i));
            }
            Console.ReadKey();
        }
    }




    class programThirteen
    {
        static void Main(string[] args)
        {


            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }





    class programF
    {
        static void Main(string[] args)
        {


            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }



    class programFifteen
    {
        static void Main(string[] args)
        {


            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }











    class programEighteen
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(word.Length);


            Console.ReadKey();
        }
    }








}
