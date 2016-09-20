using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnReflection
{
    class Demo
    {
        static void Main() {

            Assembly obj = Assembly.LoadFrom("HandsOnReflection.exe");
            Type[] t1 = obj.GetTypes();
            foreach (Type t in t1)
            {
                //if(t.IsClass)
                Console.WriteLine(t.Name);
            }
        }

    }
}
