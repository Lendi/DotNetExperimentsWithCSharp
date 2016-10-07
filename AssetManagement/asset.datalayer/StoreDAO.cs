using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asset.datalayer
{
    public class StoreDAO
    {
        assetDataContext obj = new assetDataContext();
        public List<RequestInfo> ViewRequest()
        {
            return obj.RequestInfos.Where(i => i.request_status == 3).ToList();
        }

        public void RequestApproval(int reqid, int status)
        {
            RequestInfo reqinf = obj.RequestInfos.SingleOrDefault(i => i.request_id == reqid);
            reqinf.request_status = status;
            if (status == 5)
            {                
                AssetInfo assetinf = new AssetInfo();
                assetinf.assetname= reqinf.asset_name;
                assetinf.emp_id = reqinf.emp_id;
                assetinf.request_id = reqinf.request_id;
                assetinf.issueddate = DateTime.Now;                
                assetinf.Status = "Issued";
                obj.AssetInfos.InsertOnSubmit(assetinf);
            }
            obj.SubmitChanges();
        }



    }
}
