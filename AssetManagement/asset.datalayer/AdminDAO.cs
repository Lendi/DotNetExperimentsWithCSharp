using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace asset.datalayer
{
  public class AdminDAO
    {
      assetDataContext obj = new assetDataContext();
        public void CreateUser(user ObjUser)
        {
            //using (assetDataContext obj = new assetDataContext())
            //{
            int eid = GetID();
                ObjUser.emp_id = eid;
                obj.users.InsertOnSubmit(ObjUser);
                obj.SubmitChanges(); 
           //}

        }

        public int GetID()
        {
            //using (assetDataContext obj = new assetDataContext())
            //{
            int eid = (obj.users.Select(i => i.emp_id)).Max();
            eid = eid + 1;
            return eid;
        }

      

        public void ModifyUser( int eid, string sid, string fname, string lname, string email, string pwd, int mid, 
            string desig, int phno, DateTime doj, string active)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                user usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.short_id = sid ;
                usr.fname = fname;
                usr.lname = lname;
                usr.email_id = email;
                usr.user_password = pwd;
                usr.manager_id = mid;
                usr.designation = desig;
                usr.mobile = phno;
                usr.date_of_join = doj;
                usr.active = active;

                obj.SubmitChanges();                
                
            }


        }

        public void DeleteUser(int eid) {
            using (assetDataContext obj = new assetDataContext())
            {
                user usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                obj.users.DeleteOnSubmit(usr);
                obj.SubmitChanges();
            }
        }


        public void DeactivateUser(int eid)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                user usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.active = "i";

                obj.SubmitChanges();
            }

        }


        public List<user> ViewUsers()
        {
            using (assetDataContext obj = new assetDataContext())
            {
                return obj.users.ToList();                
            }
        }

        //public void ReactivateUser(int eid)
        //{
        //    using (assetDataContext obj = new assetDataContext())
        //    {
        //        users usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
        //        usr.active = "a";

        //        obj.SubmitChanges();
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
