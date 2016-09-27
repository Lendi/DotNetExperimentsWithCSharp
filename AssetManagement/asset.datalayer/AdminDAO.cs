using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asset.datalayer
{
  public  class AdminDAO
    {
        
        public void CreateUser(users ObjUser)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                obj.users.InsertOnSubmit(ObjUser);
                obj.SubmitChanges();
            }

        }

        public void ModifyUser( int eid, string sid, string fname, string lname, string email, string pwd, int mid, 
            string desig, int phno, DateTime doj, string active, users ObjUser)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                users usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.short_id = ObjUser.short_id;
                usr.fname = ObjUser.fname;
                usr.lname = ObjUser.lname;
                usr.email_id = ObjUser.email_id;
                usr.user_password = ObjUser.user_password;
                usr.manager_id = ObjUser.manager_id;
                usr.designation = ObjUser.designation;
                usr.mobile = ObjUser.mobile;
                usr.date_of_join = ObjUser.date_of_join;
                usr.active = ObjUser.active;

                obj.SubmitChanges();
                
            }


        }


        public void DeactivateUser(int eid)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                users usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.active = "i";

                obj.SubmitChanges();
            }

        }


        public List<users> ViewUsers()
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

        public void ChangePassword(int eid, users ObjUser)
        {
            using (assetDataContext obj = new assetDataContext())
            {
                users usr = obj.users.SingleOrDefault(i => i.emp_id == eid);
                usr.user_password = ObjUser.user_password;
                obj.SubmitChanges();
            }

        }   






    }
}
