using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asset.datalayer;
namespace Asset.BusinessLayer
{
    
    public class AdminBL
    {
        AdminDAO Obj=new AdminDAO();


         public void CreateUser(user ObjUser)
        {
            Obj.CreateUser(ObjUser);
            
         }


         public void ModifyUser(int eid, string sid, string fname, string lname, string email, string pwd, int mid,
            string desig, int phno, DateTime doj, string active, user ObjUser)
         {
             Obj.ModifyUser(eid, sid, fname, lname, email, pwd, mid, desig, phno, doj, active, ObjUser);         
         }


         public void DeactivateUser(int eid) {
             Obj.DeactivateUser(eid);
         }


         public List<user> ViewUsers() {
             return Obj.ViewUsers();
         }

         //public void ReactivateUser(int eid) {
         //    Obj.ReactivateUser(eid);
         //}

         public void ChangePassword(int eid, user ObjUser) {
             Obj.ChangePassword(eid, ObjUser);
         }


    }
}
