using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace asset.datalayer
{
    public class EmployeeDAO
    {
        assetDataContext obj = new assetDataContext();


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
                //obj.RequestInfos.InsertOnSubmit(reqInf);
            //int eid = obj.users.Select

                obj.SubmitChanges();                    
        }


        public int GetReqID()
        {           
            int reqid = (obj.RequestInfos.Select(i => i.request_id)).Max();
            if (reqid == null)
            {
                return 1;
            }
            else {
                return reqid+1;
            }
            //reqid += 1;
            
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
}
