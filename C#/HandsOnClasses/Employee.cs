using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Employee
    {
        public int Eid;
        public string Ename;
        public static double Salary;
        public static string Company;
        public void Show()
        {
            Console.WriteLine("Employee Id" + Eid);
            Console.WriteLine("Employee name" + Ename);
            Console.WriteLine("Employee salary" + Salary);
            Console.WriteLine("Employee company" + Company);
        
        }

        static void Main() {
            Employee.Company = "CSC";
            Employee.Salary = 400000;
            Employee e1 = new Employee();
            e1.Eid = 1244;
            e1.Ename = "Ming";
            e1.Show();
            Console.WriteLine("--------------------------");
            Employee e2 = new Employee();
            e2.Eid = 124423;
            e2.Ename = "Bing";
            e2.Show();
            Console.WriteLine("--------------------------");
            Employee e3 = new Employee();
            e3.Eid = 124476;
            e3.Ename = "Ping";
            e3.Show();
            Console.ReadKey();
        }
        
    }
}
