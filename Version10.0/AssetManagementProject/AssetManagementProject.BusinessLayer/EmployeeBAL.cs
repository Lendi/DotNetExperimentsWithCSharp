using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AssetManagementProject.DataLayer;
namespace AssetManagementProject.BusinessLayer
{
    public class EmployeeBAL
    {
        EmployeeDAL obj=new EmployeeDAL();
        public List<UserDetail> ViewEmployeeDetails(int eid)
        {
            return obj.ViewEmployeeDetails(eid);
        }
        public void CreateAssetRequest(RequestTable rtable)
        {
             obj.CreateAssetRequest( rtable);
        }
        public ArrayList GetManagerID(int eid)
        {
            return obj.GetManagerID(eid);
        }
        public List<AssetTable> ViewMyAssets(int eid)
        {
            return obj.ViewMyAssets(eid);
        }
        public List<RequestTable> ViewMyRequest(int eid)
        {
            return obj.ViewMyRequest(eid);
        }
        //public bool AssetTransfer(int fromeid, int toeid, int assetid,string Comments)
        //{
        //   return obj.AssetTransfer(fromeid, toeid, assetid,Comments);
        //}
        public bool TransferRequest(int fromeid, int toeid, int assetid, string Comments)
        {
            return obj.TransferRequest(fromeid, toeid, assetid, Comments);
        }
        public List<UserDetail> GetAllEmployees(int eid)
        {
            return obj.GetAllEmployees(eid);
        }
        public void ChangePassword(int eid, string NewPassword)
        {
            obj.ChangePassword(eid, NewPassword);
        }
    }
}
