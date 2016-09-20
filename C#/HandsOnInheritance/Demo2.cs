using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance_2
{

    class Employee
    {
        public void Work()
        {
            Console.WriteLine("Employee Work");
        }
    }


    class Manager : Employee
    {
        new public void Work()
        {
            Console.WriteLine("Manager Work");
        }

        public void m() { 
        base.Work();// base keyword access base functions in derived class
        }
    }

    class Demo2
    {
        static void Main() {
            Manager m = new Manager();
            //when base class and derived class have same functionalitty
            m.Work();
        }
    }
}
