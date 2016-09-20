using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace HandsOnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(ArrayList);
            //Access all methods
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi) {
                Console.WriteLine(m.ReturnType.Name + " " +m.Name);
            }
            //Console.Clear();
            //access all constructors

            ConstructorInfo[] ci = t.GetConstructors();

            foreach (ConstructorInfo c in ci) {
                Console.WriteLine(c.Name);
            }
           // Console.Clear();
            double d = 2.0;
            Console.WriteLine(d.GetType());
        }
        
    }
}
