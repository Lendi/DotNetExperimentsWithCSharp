using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome";
            char c = s[2];
            Console.WriteLine(c);
            string path = "D:sg\\sgh\\srghs\\";
            string path1 = @"D:\csg\sg\sdgsg" ;
            Console.WriteLine(path1);

            foreach (char ch in s) { 
            
            }
            Console.WriteLine("mew = " + s.Length);
            Console.ReadKey();
        }
    }
}
