using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asset.datalayer;
using System.Collections;
using asset.datalayer;

namespace Asset.BusinessLayer
{
    public class LoginBL
    {       
            LoginDAO obj = new LoginDAO();
            public ArrayList LoginDetails(string uname, string pwd)
            {
                return obj.LoginDetails(uname, pwd);
            }
        
    }
}
