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
        public bool TransferRequest(int fromeid, int toeid, int assetid)
        {
            try
            {
                UserDetail us = obj.UserDetails.SingleOrDefault(i => i.Emp_ID == fromeid);
                TranserHistory th = new TranserHistory();
                th.Manager_ID = us.Manager_ID;
                th.From_Emp_ID = fromeid;
                th.To_Emp_ID = toeid;
                th.Asset_ID = assetid;
                th.Transfer_Status = 0;
                th.TransferDate = DateTime.Now;
                obj.TranserHistories.InsertOnSubmit(th);
                obj.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool AssetTransfer(int fromeid,int toeid,int assetid)
        {
            try
            {
                AssetTable asset = obj.AssetTables.SingleOrDefault(i => i.Emp_ID == fromeid && i.Asset_ID == assetid);
                asset.Emp_ID = toeid;
                obj.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }

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
