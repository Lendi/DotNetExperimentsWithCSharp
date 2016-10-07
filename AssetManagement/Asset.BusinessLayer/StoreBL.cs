using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asset.datalayer;

namespace Asset.BusinessLayer
{
    public class StoreBL
    {
        StoreDAO obj = new StoreDAO();
        public List<RequestInfo> ViewRequest()
        {
            return obj.ViewRequest();
        }
        public void RequestApproval(int reqid, int status)
        {
            obj.RequestApproval(reqid, status);
        }

    }
}
