using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Employee
    {
        public uint empID = 12314;
        private string empName;
        private double empsal;

        public double Salary
        {
            get { return empsal; }
            set { empsal = value; }
        }

        public string Name{
            get { return empName; }

            set {
                if (value != null) empName = value;
                else Console.WriteLine("Invalid Name");
            }
    
    }
        public uint ID {
            get { return empID; }

            set {
                if (value != 0) empID = value;
                else Console.WriteLine("Invalid EID");
            }
        }


        public static void Main(string[] args) {
            Employee e = new Employee();
            e.Name = "Len"; e.ID = 0; e.empsal = 12235346;
            Console.WriteLine("{0} \n{1} \n{2}", e.ID, e.Name, e.Salary);
        }
    }
}
