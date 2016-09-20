using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            //generic collections recommended over ngc. but ngc is used only when u have to store data of any type
            List<int> l1 = new List<int>() {6, 3, 1, 4, 2, 6, 7,8 };
            List<char> l2 = new List<char>() { 'f', 'h', 'l', 'y', 'u'};
            List<string> l3 = new List<string>() { "Meow" , "Hello"};
            l3.Add("Kitty");
            foreach (string s in l3)
                Console.WriteLine(s);
            Console.Clear();

            IEnumerator<string> ob = l3.GetEnumerator();
            while (ob.MoveNext())
                Console.WriteLine(ob.Current);
            Console.ReadKey();
        }
    }
}
