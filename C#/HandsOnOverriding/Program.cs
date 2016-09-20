using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverriding
{
    class Employee { 

        private int Eid;
        private string Ename;


        public Employee(int id, string name) {
            Eid = id;
            Ename = name;
        }


        public virtual void Details() {
            Console.WriteLine("Eid:" + Eid);
            Console.WriteLine("Ename:" +Ename);
        }
    }

    class Manager : Employee {

        private string Level;
        private string Dept;

        public Manager(int id, string name, string level, string dept):base(id,name) { 
            Level = level;
            Dept = dept;

        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine("Level " +Level);
            Console.WriteLine("Dept " +Dept);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager(1214, "Ben", "Level 1000", "SDE");
            e1.Details();
        }

    }

}
