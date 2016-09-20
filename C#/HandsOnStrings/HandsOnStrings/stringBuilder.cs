using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class stringBuilder
    {
        static void Main() {
            StringBuilder obj = new StringBuilder("Meowwwwwww");
            
            obj.Append("Kitty");
            
            obj.Append("Hyderabad");

            string s = "Welcome to Hyderabad";

            s.Replace("Hyderabad", "Chennai");
            obj.Replace("Hyderabad", "Chennai");
            Console.WriteLine(obj);
            Console.ReadKey();

            //string and string builder both vary in replace method; in the above example, 
        }
    }
}
