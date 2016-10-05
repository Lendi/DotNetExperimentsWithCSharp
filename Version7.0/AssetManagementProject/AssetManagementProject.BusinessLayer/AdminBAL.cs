using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.BusinessLayer
{
    public class AdminBAL
    {
        AdminDAL obj = new AdminDAL();
        public void Login_Logout()
        {
        }
        public void CreateUser(UserDetail ObjUser)
        {
            obj.CreateUser(ObjUser);
        }
        public void ModifyUser(int eid, UserDetail ObjUser)
        {
            obj.ModifyUser(eid, ObjUser);
        }
        public void DeactivateUser(int eid)
        {
            obj.DeactivateUser(eid);
        }
        public List<UserDetail> ViewUser()
        {
            return obj.ViewUser();
        }

        public void ChangePassword()
        {

        }
    }
}
