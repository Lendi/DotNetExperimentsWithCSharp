using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandsOnLinqWithObjects
{
    class Demo2
    {

        static void Main() {
            ArrayList ar = new ArrayList() { "blasdgf", "ble", "bloadf", "bli", "blu" };
            //k is of object type so we explicitly mention it as string k
            var res = from string k in ar where k.Length > 4 select k.ToUpper();
            foreach (string s in res)
                Console.WriteLine(s);       
        
        }
    }
}
