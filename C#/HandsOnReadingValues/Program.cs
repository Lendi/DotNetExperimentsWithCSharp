using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnReadingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine(); //reads the value from input
            Console.WriteLine("Gm " + name);
            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            
            Console.WriteLine("You are {0} years old, your name is {1}", age, name);
            Console.ReadKey();

        }
    }
}
