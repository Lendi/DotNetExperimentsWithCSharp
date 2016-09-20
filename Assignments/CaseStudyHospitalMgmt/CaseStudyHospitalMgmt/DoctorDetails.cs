using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    public abstract class DoctorDetails 
    {
        public string doc_name;
        public int doc_id;
        public string doc_spec;
        public bool IsAvailable;

        public abstract void GetDoctorDetails();
        public abstract bool GetDoctorAvailability(bool IsAvailable);



        public DoctorDetails() {
            Random rnd = new Random();
            doc_id = rnd.Next(1000, 9999);
        }
        }


    }

