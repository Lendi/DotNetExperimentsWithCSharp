using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace asset.datalayer
{
    public class EmployeeDAO
    {
        assetDataContext obj = new assetDataContext();

        public List<user> ViewEmployeeDetails(int eid)
        {
            List<user> usr = obj.users.Where(i => i.emp_id == eid).ToList();
            return usr;
        }

        public void CreateRequest(RequestInfo reqInf) {     
                //int reqid = (obj.RequestInfos.Select(i => i.request_id)).Max();
                //reqid = reqid + 1;
                //reqInf.request_id = reqid;
                ////RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid);  
                //reqInf.emp_id = eid;
                ////reqInf.short_id = obj.users;  
                //reqInf.asset_name = assetname;
                //reqInf.request_date = DateTime.Now;                
                //obj.SubmitChanges();

                int reqid = GetReqID();
                reqInf.request_id = reqid;

                obj.RequestInfos.InsertOnSubmit(reqInf);
                obj.SubmitChanges();       
        }

        public int GetReqID()
        {
            int reqid = (obj.RequestInfos.Select(i => i.request_id)).Max();
            if (reqid == null)
            {
                return 1;
            }
            else
            {
                return reqid + 1;
            }
            //reqid += 1;            
        }


        public List<AssetInfo> ViewMyAssets(int eid)
        {
            List<AssetInfo> asset = obj.AssetInfos.Where(i => i.emp_id == eid).ToList();
            return asset;
        }


        public List<RequestInfo> ViewMyRequests(int eid)
        {
            List<RequestInfo> Request = obj.RequestInfos.Where(i => i.emp_id == eid).ToList();
            return Request;
        }

        public ArrayList GetManagerID(int eid)
        {
            ArrayList a1 = new ArrayList();

            user usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
            int manager_id = Convert.ToInt32(usr.manager_id);
            string username = usr.short_id;
            string fname = usr.fname;
            a1.Add(manager_id);
            a1.Add(username);
            a1.Add(fname);
            return a1;
        }

        public void AssetTransfer()
        {


        }





        //public void ViewRequest(int eid, int status, DateTime Mapprovedate, )
        //{
        //    using (assetDataContext obj = new assetDataContext())
        //    {
        //        RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid);


        //    }
        //}





        public void ChangePassword(int eid, user ObjUser)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                user usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.user_password = ObjUser.user_password;
                obj.SubmitChanges();
            }

        } 
        

    }

    public class EmployeesAssets
    {
        public int Emp_Id { get; set; }
        public string FirstName { get; set; }
        public int Request_ID { get; set; }
        public string AssetName { get; set; }
        //public DateTime RequestDate { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}
