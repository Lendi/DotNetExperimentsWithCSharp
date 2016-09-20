using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    public class InPatient : PatientDetails
    {
        public DateTime AdmitDate;
        public string disease;        

        
        public override void GetPatientDetails()
        {
            //throw new NotImplementedException();

            Console.WriteLine("Name : {0}, ID : {1}, Age : {2}" + pat_name, pat_id, pat_age);
            
        }

        Hashtable ht1 = new Hashtable();
 
        //(string pat_name, int pat_id, int pat_age, DateTime pat_dob, string address, string referring_doc)
        public override void AddPatientDetails()
        {
            Console.WriteLine("Patient's ID is: {0}" + pat_id);

            Console.WriteLine("Enter Patient's name");
            pat_name = Console.ReadLine();
            ht1.Add(pat_id, pat_name);
            Console.WriteLine("Enter Patient's Age");
            pat_age = int.Parse(Console.ReadLine());
            ht1.Add(pat_id, pat_age);
            Console.WriteLine("Enter Patient's DOB");            
            pat_dob = DateTime.Parse(Console.ReadLine());
            ht1.Add(pat_id, pat_dob);
            Console.WriteLine("Enter Patient's Adddress");
            address = Console.ReadLine();
            ht1.Add(pat_id, address);
            Console.WriteLine("Enter Patient's referring doctor");
            referring_doc = Console.ReadLine();
            ht1.Add(pat_id, referring_doc);
           
            
            throw new NotImplementedException();
        }


        public void TestOrdered(string ailment) {
           
            if (ailment == "fracture") { Console.WriteLine("X ray"); }

            if (ailment == "diabetes") { Console.WriteLine("blood test"); }

            if (ailment == "malaria") { Console.WriteLine("blood test"); }

            if (ailment == "other") { Console.WriteLine("general checkup"); }
            
        }



        public override bool payBill(double tbill)
        {
            throw new NotImplementedException();
        }

        public override void RemovePatient()
        {
            throw new NotImplementedException();
        }
    }
}
