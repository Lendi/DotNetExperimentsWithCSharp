using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.BusinessLayer
{
   public class ManagerBAL:EmployeeBAL
    {
        ManagerDAL obj = new ManagerDAL();
        public List<RequestTable> GetRequests(int eid)
        {

            return obj.GetRequests(eid);
        }
        public void PendingRequestApproval(int eid, int request_id, int RequestType)
        {
            obj.PendingRequestApproval(eid,request_id,RequestType);
        }
        
        public List<EmmployeesAssets> GetMyEmployeesAssets(int eid)
        {
            return obj.GetMyEmployeesAssets(eid);
        }
        public List<UserDetail> GetMyEmployees(int eid)
        {
            return obj.GetMyEmployees(eid);
        }
        public List<TranserHistory> GetTrasferRequest(int eid)
        {
            return obj.GetTransferRequest(eid);
        }
        public void PendingTrasferRequest(int fromeid, int toeid, int assetid, int RequestType)
        {
            obj.PendingTrasferRequest( fromeid,  toeid,  assetid,  RequestType);
        }
    }

}
