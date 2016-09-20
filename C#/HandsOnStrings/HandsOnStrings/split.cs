using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class split
    {
        static void Main() {

/*            
            string[] s = {"saohg", "asrgas", "asfghh"};
            foreach(string str in s)
            {
                Console.WriteLine(str);
            }

            string joinedWord = String.Join("_", s);
            //string[] s = str.Split(',');
            Console.WriteLine(joinedWord);
*/
            string s3 = string.Join("", 10, 20, 30);
            Console.WriteLine(s3);
            
            Console.ReadKey();

        }
    }
}
