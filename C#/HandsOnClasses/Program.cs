using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Cid = 1083;
            c1.Cname = "Ruhi";
            c1.Address = "Chennai, T-nagar, 500242";
            c1.Display();
            Console.WriteLine("----------------------");
            Customer c2 = new Customer();
            c2.Display();
            //theres no memory for class, but only object. class memory allocated in heap

            Console.ReadKey();
        }
    }
}
