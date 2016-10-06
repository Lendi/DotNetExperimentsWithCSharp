using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.BusinessLayer
{
    public class StoreBAL
    {
        StoreDAL obj = new StoreDAL();
        public List<RequestTable> ViewRequest()
        {
            return obj.ViewRequest();
        }
        public void ApproveRequest(int Req_id, int status)
        {
            obj.ApproveRequest(Req_id, status);
        }
    }
}
