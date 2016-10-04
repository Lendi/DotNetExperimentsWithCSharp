using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AssetManagementProject.DataLayer
{
    public class EmployeeDAL
    {
        AssetManagementDBModelDataContext obj = new AssetManagementDBModelDataContext();
       
        public List<UserDetail> ViewEmployeeDetails(int eid)
        {
            List<UserDetail> User = obj.UserDetails.Where(i => i.Emp_ID == eid).ToList();
            return User;
        }
        public List<AssetTable> ViewMyAssets(int eid)
        {
            List<AssetTable> asset = obj.AssetTables.Where(i => i.Emp_ID == eid).ToList();
            return asset;
        }
        public List<RequestTable> ViewMyRequest(int eid)
        {
            List<RequestTable> Request = obj.RequestTables.Where(i => i.Emp_ID == eid).ToList();
            return Request;
        }
        public void AssetTransfer()
        {
            

        }
        public void CreateAssetRequest(RequestTable objRT)
        {
            obj.RequestTables.InsertOnSubmit(objRT);
            obj.SubmitChanges();
        }
        public ArrayList GetManagerID(int eid)
        {
            ArrayList a1 = new ArrayList();
           
            UserDetail User = obj.UserDetails.SingleOrDefault(i => i.Emp_ID == eid);
            int Manager_id = Convert.ToInt32(User.Manager_ID);
            string Short_id = User.Short_ID;
            a1.Add(Manager_id);
            a1.Add(Short_id);
            return a1;
        }

       
    }
}
