using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance_1
{
    class Employee {

        protected int eid;
        protected string ename;


        public Employee(int id, string name) {
            eid = id;
            ename = name;

        }


        public Employee() {
            Console.WriteLine("Employee Created");
        }
    }

    
    class Manager:Employee {
        private string level;

        public Manager() {
            Console.WriteLine("Manager Created");
        }

        public Manager(int id, string name, string level): base(id, name) {
            this.level = level;

        }

        public void Details()
        {
            Console.WriteLine("Eid: " + eid);
            Console.WriteLine("Ename: " + ename);      
            Console.WriteLine("Level: " + level);
        }


    }
    
    
    class Demo1
    {
        static void Main() {
            Manager obj = new Manager();
            Console.WriteLine("\n");
            Manager obj1 = new Manager(1000, "lendi", "level 10");
            Console.WriteLine("\n");
            obj.Details();
            Console.WriteLine("\n");
            obj1.Details();
        }
    }
}
