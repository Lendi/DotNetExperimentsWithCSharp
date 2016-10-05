using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asset.datalayer;
using System.Collections;

namespace Asset.BusinessLayer
{
     public class EmployeeBL
    {
         EmployeeDAO obj = new EmployeeDAO();

         //viewing my own details
         public List<user> ViewEmployeeDetails(int eid) {
             return obj.ViewEmployeeDetails(eid);
         }

         //creating a request
         public void CreateRequest(RequestInfo reqInf)
         {
             obj.CreateRequest(reqInf);
         }

         //viewing all my requests -- status etc
         public List<RequestInfo> ViewMyRequest(int eid)
         {
             return obj.ViewMyRequests(eid);
         }

         //get my manager id
         public ArrayList GetManagerID(int eid)
         {
             return obj.GetManagerID(eid);
         }

         //my assets
         public List<AssetInfo> ViewMyAssets(int eid)
         {
             return obj.ViewMyAssets(eid);
         }
         
         
        
    }
}
