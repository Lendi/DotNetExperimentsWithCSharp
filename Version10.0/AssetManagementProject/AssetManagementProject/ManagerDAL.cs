using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementProject.DataLayer
{
    public class ManagerDAL:EmployeeDAL
    {
        AssetManagementDBModelDataContext obj = new AssetManagementDBModelDataContext();
        public List<RequestTable> GetRequests(int eid)
        {
            List<RequestTable> list = obj.RequestTables.Where(i => i.Manager_ID == eid&&i.Status==1).ToList();

            return list;
        }
        public List<TranserHistory> GetTransferRequest(int eid)
        {
            List<TranserHistory> list = obj.TranserHistories.Where(i => i.Manager_ID == eid && i.Transfer_Status==0).ToList();
            return list;
        }
        public void PendingRequestApproval(int eid,int request_id,int RequestType)
        {
            RequestTable r = obj.RequestTables.SingleOrDefault(i => i.Emp_ID == eid && i.Request_ID == request_id);
            r.Status = RequestType;
           //r.Remarks_Comment = Comments;
            if (RequestType == 3)
            {
                r.ManagerApprovedDate = DateTime.Now;
            }
            obj.SubmitChanges();
        }
        public void PendingTrasferRequest(int fromeid, int toeid, int assetid,int RequestType)
        {
            TranserHistory r = obj.TranserHistories.SingleOrDefault(i => i.From_Emp_ID == fromeid && i.Asset_ID == assetid);
            r.Transfer_Status = RequestType;
            
            if (RequestType == 1)
            {
                r.TransferDate = DateTime.Now;
                AssetTable asset = obj.AssetTables.SingleOrDefault(i => i.Emp_ID == fromeid && i.Asset_ID == assetid);
                asset.Emp_ID = toeid;
                asset.Status = "In Use";
            }
            obj.SubmitChanges();
        }

        public List<UserDetail> GetMyEmployees(int eid)
        {
            List<UserDetail> usr = obj.UserDetails.Where(i => i.Manager_ID == eid).ToList();
            return usr;
        }
        public List<EmmployeesAssets> GetMyEmployeesAssets(int eid)
        {

            var tab = (from c in obj.UserDetails join c1 in obj.AssetTables on c.Emp_ID equals c1.Emp_ID where c.Manager_ID == eid select new EmmployeesAssets { Emp_Id = c.Emp_ID, FirstName = c.FirstName, Request_ID = (int)c1.Request_ID, AssetName = c1.AssetName, IssuedDate = (DateTime) c1.IssuedDate }).ToList();
            return tab;
        }
        
       
        

    }
}
