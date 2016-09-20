using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{

    class Employee {
        public int Eid;
        public string Ename;
    }


    class Manager: Employee {
        public string Dept;
        public string Level;

        public Manager(){ }

        public Manager(int eid, string ename, string dept, string level) {
            this.Eid = eid;
            this.Ename = ename;
            this.Dept = dept;
            this.Level = level;            
        }


        public void Details() {
            Console.WriteLine("Eid: " + Eid);
            Console.WriteLine("Ename: " + Ename);
            Console.WriteLine("Department name: " + Dept);
            Console.WriteLine("Level: " + Level);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Eid = 1000;
            m.Ename = "ROhan";
            m.Dept = "HR";
            m.Level = "level 2";
            m.Details();

            Manager m1 = new Manager(145, "Ching", "PR", "Level 1");
            m1.Details();
        }
    }
}
