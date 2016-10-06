using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.DataLayer
{
    
   public class AdminDAL
    {
       AssetManagementDBModelDataContext obj=new AssetManagementDBModelDataContext();
        public void Login_Logout()
        {
        }
        public bool CreateUser(UserDetail ObjUser)
        {
            try
            {
                obj.UserDetails.InsertOnSubmit(ObjUser);
                obj.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public UserDetail GetUserById(int eid)
        {
            return obj.UserDetails.SingleOrDefault(i => i.Emp_ID == eid);
        }
        public void ModifyUser(int eid, UserDetail ObjUser)
        {
            UserDetail User = obj.UserDetails.SingleOrDefault(i => i.Emp_ID == eid);
            User.FirstName = ObjUser.FirstName;
            User.LastName = ObjUser.LastName;
            User.Email_ID = ObjUser.Email_ID;
            User.Manager_ID = ObjUser.Manager_ID;
            User.Designation = ObjUser.Designation;
            User.Mobile = ObjUser.Mobile;
            obj.SubmitChanges();
        }
        public void DeactivateUser(int eid)
        {
            UserDetail User = obj.UserDetails.SingleOrDefault(i => i.Emp_ID == eid);
            User.Active = "I";
            obj.SubmitChanges();
        }
        public List<UserDetail> ViewUser()
        {
            return obj.UserDetails.ToList();
        }
        
        public void ChangePassword()
        {

        }
    }
}
