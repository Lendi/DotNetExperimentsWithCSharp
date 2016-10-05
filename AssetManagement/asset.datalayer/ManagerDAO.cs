using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace asset.datalayer
{
    public class ManagerDAO:EmployeeDAO
    {
        assetDataContext obj = new assetDataContext();


        public List<RequestInfo> GetRequests(int eid)
        {
            List<RequestInfo> list = obj.RequestInfos.Where(i => i.manager_id == eid && i.request_status == 1).ToList();

            return list;
        }

        //list of requests that arent approved yet

        public void ApproveReject(int eid, int req_id, int reqstatus, string remarks)
        {
            if (reqstatus == 5) //approve it & forward to store
            {
                RequestInfo reqinf  = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid && i.request_id == req_id);
                reqinf.request_status = reqstatus;
                reqinf.manager_approved_date = DateTime.Now;
                reqinf.remarks = remarks;
                obj.SubmitChanges();
            }
            if (reqstatus == 4) //reject it
            {
                RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid && i.request_id == req_id);
                reqinf.request_status = reqstatus;
                reqinf.remarks = remarks;
                obj.SubmitChanges();
            }
        }


        public List<user> GetEmployees(int eid) //all employees under me
        {
            List<user> usr = obj.users.Where(i => i.manager_id == eid).ToList();
            return usr;
        }


        public List<EmployeeAssets> GetEmployeesAssets(int eid) //all my employees assets
        {
            var myempassets = (from u in obj.users join a in obj.AssetInfos on u.emp_id equals a.emp_id
                               where u.manager_id == eid 
                               select new EmployeeAssets { employeeid = (int)a.emp_id,
                                   firstname = u.fname,
                                   assetid = (int)a.asset_id,
                                   assetname = a.assetname,
                                   requestid = (int)a.request_id,                                   
                                   issuedate = (DateTime) a.issueddate
                               }).ToList();
            return myempassets;
           
        }
    }
    
}
//separate class for getting and setting employee assets and equating them to values in table
public class EmployeeAssets
{
    public int employeeid { get; set; }
    public string firstname { get; set; }
    public int assetid { get; set; }
    public string assetname { get; set; }
    public int requestid { get; set; }
    public DateTime issuedate { get; set; }
}