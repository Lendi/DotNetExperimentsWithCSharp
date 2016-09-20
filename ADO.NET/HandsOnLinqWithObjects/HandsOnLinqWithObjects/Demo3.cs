using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinqWithObjects
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
    }

    class Demo3 {
        static void Main() {
            Employee e1 = new Employee() { Eid = 1, Ename = "Len", Salary = 12000 };
            Employee e2 = new Employee() { Eid = 2, Ename = "ben", Salary = 32000 };
            Employee e3 = new Employee() { Eid = 3, Ename = "ken", Salary = 52000 };
            Employee e4 = new Employee() { Eid = 4, Ename = "sen", Salary = 72000 };
            Employee e5 = new Employee() { Eid = 5, Ename = "den", Salary = 92000 };
            Employee e6 = new Employee() { Eid = 6, Ename = "ren", Salary = 12000 };
            List<Employee> list = new List<Employee>() { e1, e2, e3, e4, e5, e6};

            //very very imp example on using collections with LINQ

            var res = from l in list select l;
            res = (from l in list orderby l.Salary select l).Take(2);
            res = (from l in list orderby l.Salary select l).Skip(2);
//            res = from l in list where l.Ename == "ken" select l;
            foreach (Employee e in res)
                Console.WriteLine("{0} {1} {2}", e.Eid, e.Ename, e.Salary);
//            Console.Clear();
//            var res1 = from l in list select new {l.Eid, l.Ename};
//            //new {l.Eid, l.Ename}; is an anonymous object - the concept of creating obj without class
//            //res1 is array of anonymous objects
//            foreach (var k in res1)
//                Console.WriteLine(k.Eid + " " + k.Ename);

//            int k1 = (from l in list select l).Count();
//            var k2 = (from l in list select l.Salary).Max();
//            Console.WriteLine(k2);
        }
    
    }
}
