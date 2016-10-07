using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asset.datalayer;
namespace Asset.BusinessLayer
{
    public class ManagerBL:EmployeeBL
    {
        ManagerDAO obj = new ManagerDAO();


        public List<RequestInfo> GetRequests(int eid)
        {
            return obj.GetRequests(eid);
        }

        public List<TransferHistory> GetTransferRequest(int eid) {
            return obj.GetTransferRequest(eid);
        }

        public void NormalRequests(int eid, int req_id, int reqstatus, string remarks) {
            obj.NormalRequests(eid, req_id, reqstatus, remarks);
        }

        public void TransferRequests(int from_eid, int to_eid, int asset_id, int trans_status) {
            obj.TransferRequests(from_eid, to_eid, asset_id, trans_status);
        }

  
        public List<EmployeeAssets> GetEmployeesAssets(int eid)
        {
            return obj.GetEmployeesAssets(eid);
        }


        public List<user> GetEmployees(int eid)
        {
            return obj.GetEmployees(eid);
        }
    }
}
