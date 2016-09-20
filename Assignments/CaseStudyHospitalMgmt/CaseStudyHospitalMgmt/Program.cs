using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("1. Admit patient 2. Discharge Patient 3. Doctor Details 4. Paybill");
                Console.WriteLine("Enter choice");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                    //admit patient
                {
                    Console.WriteLine("1. Enter Inpatient Details 2. Display Inpatient Details 3. Treatment");

                    if (ch == 1) {
                        InPatient ip = new InPatient();
                        ip.AddPatientDetails();
                    }

                    if (ch == 2) {
                        InPatient ip = new InPatient();
                        ip.GetPatientDetails();
                    }
                    if (ch == 3) {
                        Console.WriteLine("Enter ailment");
                        InPatient ip = new InPatient();                        
                        ip.TestOrdered(Console.ReadLine());
                    }



                }

                if (ch == 2) 
                {
                    Console.WriteLine("1. Get Bill 2. Get Patient Summary 3. Remove Patient ");
                    if (ch == 1) {
                        OutPatient op = new OutPatient();
                        op.getBill();
                    }

                    if (ch == 2) {
                        OutPatient op = new OutPatient();
                        op.getPatientSummary();
                    }

                    if (ch == 3)
                    {
                        OutPatient op = new OutPatient();
                        op.RemovePatient();
                    }
                }


                if (ch == 3) {
                    Doctor doc = new Doctor();
                    doc.GetDoctorDetails();

                }

                if (ch == 4) { 
                    OutPatient op = new OutPatient();
                    op.payBill(double.Parse(Console.ReadLine()));
                    
                                    
                }
            
            }
        }
    }
}
