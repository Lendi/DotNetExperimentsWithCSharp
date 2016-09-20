using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyHospitalMgmt
{
    public class OutPatient : PatientDetails   
    {
        public int roomno;
        public DateTime admitdate;
        public DateTime dischargedate;
        public int fee;
        public int min_rent_per_day;
        public string consulting_doc;

        Hashtable ht2 = new Hashtable();

        

        public void getBill() {

            Console.WriteLine("Enter patient ID");
            pat_id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter room number");
            roomno = int.Parse(Console.ReadLine());
            ht2.Add(pat_id, roomno);

            Console.WriteLine("Enter admit date");
            admitdate = DateTime.Parse(Console.ReadLine());
            ht2.Add(roomno, admitdate);

            Console.WriteLine("Enter discharge date");
            admitdate = DateTime.Parse(Console.ReadLine());
            ht2.Add(roomno, dischargedate);

            Console.WriteLine("Enter Consulting doctor");
            consulting_doc = Console.ReadLine();
            ht2.Add(roomno, consulting_doc);

            Console.WriteLine("Enter fees");
            fee = int.Parse(Console.ReadLine());
            ht2.Add(roomno, fee);

            Console.WriteLine("Enter daily rent");
            min_rent_per_day = int.Parse(Console.ReadLine());
            ht2.Add(roomno, min_rent_per_day);

            double totalBill = fee + ((dischargedate - admitdate).TotalDays * min_rent_per_day);

            payBill(totalBill);

        }

        public override bool payBill(double tbill) {
            Console.WriteLine("Would you like to pay your bill now?");
            bool answer =bool.Parse(Console.ReadLine());

            if (answer == true) {
                tbill = 0.0;
                return true;
            }
            else{
                return false;
            }
            
        
        }

  
        public void getPatientSummary() {
            Console.WriteLine("Patient {0} was admitted here on {1}, was treated by {2}, discharged on {3}" +pat_id, admitdate, referring_doc, dischargedate );
        
        }

      
        public override void RemovePatient()
        {
            if (payBill(tbill) == true)
            {
                ht2.Remove(pat_id);
                ht2.Remove(roomno);
                Console.WriteLine("Patient Details Successfully Removed! :) ");
            }
            else {

                Console.WriteLine("Please pay outstanding fee");
            }
            
        }

        public override void GetPatientDetails()
        {
            throw new NotImplementedException();
        }

        public override void AddPatientDetails()
        {
            throw new NotImplementedException();
        }
    }
}
