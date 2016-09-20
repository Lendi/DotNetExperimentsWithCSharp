using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class9
    {
        static void Main() {
            string[,] login = {
                            {"len", "123"}, 
                            {"ben", "123"},
                            {"ken", "123"}, 
                            {"sen", "123"}
                            };
            Console.WriteLine("Enter uname");
            String uname = Console.ReadLine();

            Console.WriteLine("Enter pwd");
            String pwd = Console.ReadLine();

            bool flag = false;

            for (int i = 0; i < 4; i++) {

                if (uname == login[i, 0] && pwd == login[i, 1]) {
                    flag = true;
                    Console.WriteLine("Valid user");
                    break;
                }
            
            }
            if (!flag) {
                Console.WriteLine("Invalid user");
            }
            Console.ReadKey();
        }
    }
}
