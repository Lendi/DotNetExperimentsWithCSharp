using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class2
    {
        static void Main() 
        {

            int flag = 0;
            string[] names = { "karan", "arjun", "lendi", "ironman" };


            do
            {

                Console.WriteLine("Enter name");
                string name = Console.ReadLine();

                foreach (string s in names)
                {
                    if (name == s)
                    {
                        flag = 1;
                        Console.WriteLine("Exists");
                        break;
                    }


                }
                if (flag == 0)
                    Console.WriteLine("Not exists");
                Console.ReadKey();

            }
            while (flag == 0);

            }
       

        
        
        }


    }

