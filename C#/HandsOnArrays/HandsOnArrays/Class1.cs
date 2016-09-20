using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class1
    {
        static void Main() {
            char[] ch = { 'a', 'b', 'c', 'd'};
            double[] d = { 32.23, 32.1, 78,2};
            object[] o = {'a', "lendi", 1358, 139.3956};
            string[] str = {"lendi", "vihari", "lendi"};


            foreach(char c in ch){
            
            Console.WriteLine(c);
            }

            foreach(double c in d){
            
            Console.WriteLine(c);
            }


             foreach(object c in o){
            
            Console.WriteLine(c);
            }

             foreach(string c in str){
            
            Console.WriteLine(c);
            }

            Console.ReadKey();

        }

    }
}
