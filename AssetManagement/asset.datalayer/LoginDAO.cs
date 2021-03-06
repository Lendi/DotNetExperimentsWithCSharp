﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace asset.datalayer
{
    public class LoginDAO
    {
        assetDataContext obj = new assetDataContext();
        public ArrayList LoginDetails(string uname, string pwd) {
  
            int eid;
            ArrayList al = new ArrayList();
            user usr = obj.users.SingleOrDefault(i => i.short_id == uname && i.user_password == pwd);

            try
            {
                if (usr.short_id == uname)
                {
                    eid = usr.emp_id;
                    al.Add(eid);
                    al.Add("Employee");
                }


                var objuser = from al1 in obj.users
                              join al2 in obj.users on al1.emp_id equals al2.manager_id
                              select new { al1.short_id, al1.user_password, al1.emp_id};


                foreach (var a in objuser)
                {
                    if (uname == a.short_id && pwd == a.user_password)
                    {
                        al.Clear();
                        eid = a.emp_id;
                        al.Add(eid);
                        al.Add("Manager");
                        return al;
                    }

                }
                return al;
            }
            catch (Exception)
            {
                al.Clear();
                al.Add("err");
                return al;
            }

        }
    }
}
