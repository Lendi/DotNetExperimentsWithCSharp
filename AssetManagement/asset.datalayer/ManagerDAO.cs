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

        //normal requests
        public List<RequestInfo> GetRequests(int eid)
        {
            List<RequestInfo> list = obj.RequestInfos.Where(i => i.manager_id == eid && i.request_status == 1).ToList();

            return list;
        }

        //get transfer requests
        public List<TransferHistory> GetTransferRequest(int eid)
        {
            List<TransferHistory> list = obj.TransferHistories.Where(i => i.manager_id == eid && i.transferstatus == 0).ToList();
            return list;
        }

       //normal asset requests 

        public void NormalRequests(int eid, int req_id, int reqstatus, string remarks)
        {

            RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid && i.request_id == req_id);
            reqinf.request_status = reqstatus  ;
            reqinf.remarks = remarks;           
            if (reqstatus == 3) //
            {
                reqinf.manager_approved_date = DateTime.Now;
            }
            obj.SubmitChanges();

            //if (reqstatus == 5) //approve it & forward to store
            //{
            //    RequestInfo reqinf  = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid && i.request_id == req_id);
            //    reqinf.request_status = reqstatus;
            //    reqinf.manager_approved_date = DateTime.Now;
            //    reqinf.remarks = remarks;
            //    obj.SubmitChanges();
            //}
            //if (reqstatus == 4) //reject it
            //{
            //    RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid && i.request_id == req_id);
            //    reqinf.request_status = reqstatus;
            //    reqinf.remarks = remarks;
            //    obj.SubmitChanges();
            //}



        }



        public void TransferRequests(int from_eid, int to_eid, int asset_id, int trans_status)
        {
            TransferHistory tranHistory = obj.TransferHistories.SingleOrDefault(i => i.from_emp_id == from_eid && i.asset_id == asset_id);
            tranHistory.transferstatus = trans_status;

            if (trans_status == 1)
            {
                tranHistory.transferdate = DateTime.Now;
                AssetInfo assetInf = obj.AssetInfos.SingleOrDefault(i => i.emp_id == from_eid && i.asset_id == asset_id);
                assetInf.emp_id = to_eid;
                assetInf.Status = "Issued";
            }
            obj.SubmitChanges();
        }
        


        public List<user> GetEmployees(int eid) //employees under me
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