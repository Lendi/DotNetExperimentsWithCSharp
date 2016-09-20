using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    class City
    {
        public string cityName;
        public bool hasAirport;
        public int population;
        public int Cpopulation;
        public int EduAdu;
        public int Nfamilies;
        public string[] locality;

        public bool IsGoodCity(string cname, bool air, int pop, int cpop, int edu, int nfam,string[] loc) {


            //name of city > seven chars
            if (cname.Length < 7)
            {
                return false;
            }            
            //has airport or not

            if (!hasAirport) { return false; }

            //educated folks in the city 

            if (EduAdu < (0.7 * (pop - cpop))) { return false; }
           
            //average no of children in each fam

            if ((cpop / nfam) < 0.9 && (cpop / nfam) > 2.1) { return false; }

            //atleast 3 localities ends with 'ganj'
            foreach (String k in loc) {
                if(!k.EndsWith("ganj")){return false;}
                }

            //city name has atleast 4 diff chars

            if (cname.Distinct().Count() < 4) { return false; }

            else
            { 
          
                return true; }


        }




        static void Main(string[] args)
        {
            City cy = new City();

            bool result = cy.IsGoodCity("hyderabad", true, 500, 250, 350, 250, new string[] { "pingpingganj", "mingmingganj", "nomnomganj", "raniganj", "pompom"} );

            if (result == true)
            {
                Console.WriteLine("This is the best city in the world");
            }
            else {
                Console.WriteLine("This is the worst city in the world");
            }
        }
    }
}
