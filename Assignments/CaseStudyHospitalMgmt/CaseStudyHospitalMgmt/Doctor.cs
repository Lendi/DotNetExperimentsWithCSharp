using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    public class Doctor: DoctorDetails
    {

        //string doc_name, int doc_id, string doc_spec, bool IsAvailable

      

        public override void GetDoctorDetails()
        {
            Console.WriteLine("Doctors's ID is: {0}" + doc_id);

            Console.WriteLine("Enter Doctors's name");
            doc_name = Console.ReadLine();
            Console.WriteLine("Enter Doctor's Specialization ");
            doc_spec = Console.ReadLine();
            Console.WriteLine("Enter Doctors's Availability: True/False");
            IsAvailable = GetDoctorAvailability(bool.Parse((Console.ReadLine())));

        }


        public override bool GetDoctorAvailability(bool IsAvailable)
        {

            if (IsAvailable == true)
            {
                Console.WriteLine("Doctor is available");
                Console.WriteLine(doc_name);
                Console.WriteLine(doc_id);
                Console.WriteLine(doc_spec);
                return true;
            }


            else
            {
                Console.WriteLine("Doctor is NOT available");
                return false;
            }

           

            
        }
    }
}
