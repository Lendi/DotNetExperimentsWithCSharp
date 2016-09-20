using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenerics
{
    class Sample{
    //generic method
        public void Doit<T>(T a){
            // T is a placeholder a is a variable which can have any value
            Console.WriteLine(a);
        }
    } 



    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.Doit<int>(100);
            s.Doit<char>('b');
            s.Doit<string>("Hello");
            s.Doit<ArrayList>(new ArrayList());
        }
    }
}
