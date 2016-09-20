using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    public abstract class PatientDetails
    {
        public string pat_name;
        public int pat_id;
        public int pat_age;
        public DateTime pat_dob;
        public string address;
        public string referring_doc;
        public double tbill;

        public abstract void GetPatientDetails();
        public abstract void AddPatientDetails();
        public abstract bool payBill(double tbill);
        public abstract void RemovePatient();

        public PatientDetails()
        {
            Random rnd = new Random();
            pat_id = rnd.Next(1000, 9999);
        }
       
    }
    


}
