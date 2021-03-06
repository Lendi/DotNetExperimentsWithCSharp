﻿using System;
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

         //public int GetID()
         //{
         //    return Obj.GetID();
         //}


         public void ModifyUser(int eid, string sid, string fname, string lname, string email, string pwd, int mid,
            string desig, int phno, DateTime doj, string active)
         {
             Obj.ModifyUser(eid, sid, fname, lname, email, pwd, mid, desig, phno, doj, active);         
         }


         public void DeactivateUser(int eid) {
             Obj.DeactivateUser(eid);
         }

         public void DeleteUser(int eid) {
             Obj.DeleteUser(eid);
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
