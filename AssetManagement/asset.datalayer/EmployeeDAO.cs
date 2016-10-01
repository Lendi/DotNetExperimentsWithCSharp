using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asset.datalayer
{
    public class EmployeeDAO
    {

        //public List<users> ViewProfile()
        //{
        //    using (assetDataContext obj = new assetDataContext())
        //    {
               
        //    }
        //}

        public void CreateRequest(int eid, string assetname) {
            using (assetDataContext obj = new assetDataContext()) {
                RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid);
                reqinf.asset_name = assetname;
                obj.SubmitChanges();
                                            
            }        
        }

        public void ViewRequest(int eid, int status, DateTime Mapprovedate) {
            using (assetDataContext obj = new assetDataContext()) {
                RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.emp_id == eid);
                //
            
            }
        }

        

    }
}
