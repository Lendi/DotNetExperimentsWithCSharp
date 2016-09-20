using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Customer
    {
        //declare data members
        public int Cid;
        public string Cname;
        public string Address;

        //methods


        // show details of customers 
        public void Display() {
            Console.WriteLine("CID = " + Cid);
            Console.WriteLine("Cname = " + Cname);
            Console.WriteLine("Address = " + Address);

           
        }
       //  Console.ReadKey();
            
    }
}
