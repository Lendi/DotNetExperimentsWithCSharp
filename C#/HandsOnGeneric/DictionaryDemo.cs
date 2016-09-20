using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGeneric
{
    class DictionaryDemo
    {
        static void Main() {
            Dictionary<char, string> ob = new Dictionary<char, string>();
            ob.Add('a', "America");
            ob.Add('b', "Britain");
            ob.Add('c', "Canada");
            ob.Add('d', "Denmark");
            ob.Add('e', "Egypt");

            string str = ob['i'];

            foreach (char ch in ob.Keys) {
                Console.WriteLine("{0} {1}", ch, ob[ch]);
            }

            foreach (KeyValuePair<char, string> k in ob)
                Console.WriteLine("{0} {1}", k.Key, k.Value);
            Console.ReadKey();
        }
    }
}
