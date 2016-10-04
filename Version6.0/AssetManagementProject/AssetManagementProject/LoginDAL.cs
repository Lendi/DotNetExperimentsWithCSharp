using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AssetManagementProject.DataLayer
{
    public class LoginDAL
    {
        AssetManagementDBModelDataContext obj = new AssetManagementDBModelDataContext();
        public ArrayList Login_Check(string uname,string pass)
        {
            string UserName = uname;
            string Password = pass;
            int eid;
            ArrayList o=new ArrayList();
            UserDetail user = obj.UserDetails.SingleOrDefault(i => i.Email_ID == UserName&&i.Password==Password);

            try
            {
                if (user.Email_ID == UserName)
                {
                    eid = user.Emp_ID;
                    o.Add(eid);
                    o.Add("Employee");
                }
                var ObjUSer = from o1 in obj.UserDetails
                              join o2 in obj.UserDetails on o1.Emp_ID equals o2.Manager_ID
                              select new { o1.Email_ID, o1.Password, o1.Emp_ID };
                foreach (var k in ObjUSer)
                {
                    if (UserName == k.Email_ID && Password == k.Password)
                    {
                        o.Clear();
                        eid = k.Emp_ID;
                        o.Add(eid);
                        o.Add("Manager");
                        return o;
                    }

                }
                return o;
            }
            catch (Exception)
            {
                o.Clear();
                o.Add("Error");
                return o;
            }
            
        }
    }
}
