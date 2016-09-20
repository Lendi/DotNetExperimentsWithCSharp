using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStruct
{
    class City
    {
        private string cityName;
        private string[] localityName;      
        private bool hasAirport;
        private int totalPopulation;
        private int totalChildren;
        private int totalFamilies;
        private int totalEducatedChildren;

      
        public string Name
        {
            get { return cityName; }
            set {
                if (cityName.Length > 7) cityName = value;
                else Console.WriteLine("Invalid Cityname");
                }
        }



        public bool HasAirport
        {
            get { return hasAirport; }
            set
            {
                if (hasAirport) Console.WriteLine("There is an airport in the city");
                else Console.WriteLine("No airport in the city");
            }
        }



       

        public int EducatedMembers
        {
            get { return totalEducatedChildren; }

            set { if(tot)totalEducatedChildren = value; }
        }
       

       



        public static void Main(string[] args) {
            City c = new City();
            c.cityName = "Hyderabad";
            c.hasAirport = true;
            c.totalPopulation = 1200000;
            c.totalChildren = 600000;
            c.totalFamilies = 800000;


        
        }

    }
}
