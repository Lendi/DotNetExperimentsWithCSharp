using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementProject.DataLayer
{
    public class StoreDAL
    {
        AssetManagementDBModelDataContext obj = new AssetManagementDBModelDataContext();
        public List<RequestTable> ViewRequest()
        {
            return obj.RequestTables.Where(i => i.Status == 3).ToList();
        }
        public void ApproveRequest(int Req_id,int status)
        {
            RequestTable rt = obj.RequestTables.SingleOrDefault(i => i.Request_ID == Req_id);
            rt.Status = status;
            if (status == 5)
            {
                //rt.Status = status;
                AssetTable at = new AssetTable();
                at.AssetName = rt.AssetName;
                at.Emp_ID = rt.Emp_ID;
                at.IssuedDate = DateTime.Now;
                at.Request_ID = rt.Request_ID;
                at.Status = "In Use";
                obj.AssetTables.InsertOnSubmit(at);
            }
            obj.SubmitChanges();
        }


      
    }
}
