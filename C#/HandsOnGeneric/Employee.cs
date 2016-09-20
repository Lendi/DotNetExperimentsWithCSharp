using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGeneric
{
   
    class Employee{
        public int empid;
        public string ename;
        public string edesig;    
    }
    class ListDemo1
    {
        static void Main(){

            Employee e1 = new Employee() { empid = 123, ename = "Mike", edesig = "Teamleader" };
            Employee e2 = new Employee() { empid = 231, ename = "Mike2", edesig = "Project Manager" };
            Employee e3 = new Employee() { empid = 321, ename = "Mickey", edesig = "Programmer" };
            Employee e4 = new Employee() { empid = 432, ename = "Millie", edesig = "Teamleader" };

            List<Employee> emplist = new List<Employee>() { e1, e2, e3, e4};
            foreach (Employee e in emplist) {
                Console.WriteLine("{0} {1} {2}", e.empid, e.ename, e.edesig);
            }

            Console.WriteLine("Enter Employee ID");
            int eid = int.Parse(Console.ReadLine());

            
        }
    }
}
