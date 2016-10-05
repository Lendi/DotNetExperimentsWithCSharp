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
        public void ApproveReject(int eid, int request_id, int rstatus, string remarks)
        {
            obj.ApproveReject(eid, request_id, rstatus, remarks);
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
