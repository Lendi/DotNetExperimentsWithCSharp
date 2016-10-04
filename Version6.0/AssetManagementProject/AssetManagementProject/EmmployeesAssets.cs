using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementProject
{
    public class EmmployeesAssets
    {
        public int Emp_Id { get; set; }
        public string FirstName { get; set; }
        public int Request_ID { get; set; }
        public string AssetName { get; set; }
        //public DateTime RequestDate { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}
