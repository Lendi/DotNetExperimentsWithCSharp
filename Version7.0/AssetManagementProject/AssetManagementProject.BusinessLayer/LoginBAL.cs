using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.BusinessLayer
{
    public class LoginBAL
    {
        LoginDAL obj = new LoginDAL();
        public ArrayList Login_Check(string uname, string pass)
        {
            return obj.Login_Check(uname, pass);
        }
    }
}
