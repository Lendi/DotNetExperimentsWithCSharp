using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface iGovtRules
    {
        double epf(double bs);
 
        string Leave();
        double Gamt(float serviceCompleted, double bs);
    }

    public class TCS : iGovtRules {

        private int empid;
        private string empname;
        private string department;
        private string designation;
        private double basicsal;
 
        public TCS(int eid, string ename, string dept,string desig,double bs) {
            empid = eid;
            empname = ename;
            department = dept;
            designation = desig;
            basicsal = bs;
 

        }

        public double epf(double bs) {
            return ((0.12 * bs)+(0.083*bs)) ;

        }

        public string Leave() {

            return "1 day of Casual Leave per month \n 12 days of Sick Leave per year \n 10 days of Previlage Leave per year";
        }

        public double Gamt(float serviceCompleted, double bs) {
            if (serviceCompleted > 5)
                return bs;
            if (serviceCompleted > 10)
                return (2 * bs);
            if (serviceCompleted > 20)
                return (3 * bs);
            else
                return 0.0;
        
        }

    }

    public class Acc : iGovtRules { 
        private int empid;
        private string empname;
        private string department;
        private string designation;
        private double basicsal;


        public Acc(int eid, string ename, string dept,string desig,double bs ) {
            empid = eid;
            empname = ename;
            department = dept;
            designation = desig;
            basicsal = bs;
       

        }


        public double epf(double bs)
        {
            return ((0.12 * bs) + (0.12 * bs));

        }
        public string Leave()
        {

            return "2 day of Casual Leave per month \n 5 days of Sick Leave per year \n 5 days of Previlage Leave per year";
        }

        public double Gamt(float serviceCompleted, double bs)
        {
            return 0.0;
        }
    
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            iGovtRules igr = new TCS(1312, "Rithika", "HR","teamlead", 100000);
            Console.WriteLine(igr.epf(100000));
            Console.WriteLine(igr.Leave());
            Console.WriteLine(igr.Gamt(10,100000));
            iGovtRules igr1 = new Acc(5465, "lendi", "HR", "manager",200000);
            Console.WriteLine(igr1.epf(200000));
            Console.WriteLine(igr1.Leave());
            Console.WriteLine(igr1.Gamt(6,200000));

          
        }
    }
}
