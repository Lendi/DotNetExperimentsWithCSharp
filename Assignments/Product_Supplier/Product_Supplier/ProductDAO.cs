using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Supplier.Datalayer
{
    public class ProductDAO
    {
        public List<Product_Detail> GetProductByProdId(int pid) { 
        using(ModelDataContext obj = new ModelDataContext()){
            return obj.Product_Details.Where(i => i.prodid == pid).ToList();
        }
        }

        public void AddProduct(Product_Detail objProd)
        {
            using (ModelDataContext obj = new ModelDataContext())
            {
                obj.Product_Details.InsertOnSubmit(objProd);
                obj.SubmitChanges();
            }


        }

        public void UpdateEmployee(int pid, string pname, int sid)
        {
            using (ModelDataContext obj = new ModelDataContext())
            {
                Product_Detail pd = obj.Product_Details.SingleOrDefault(i => i.prodid == pid);
                pd.prodid = pid;
                pd.prodname = pname;
                pd.supplierid = sid;
                obj.SubmitChanges();
                
            }


        }

        public void DeleteEmployee(int pid)
        {
            using (ModelDataContext obj = new ModelDataContext())
            {
                Product_Detail pd = obj.Product_Details.SingleOrDefault(i => i.prodid == pid);
                obj.Product_Details.DeleteOnSubmit(pd);
                obj.SubmitChanges();
            }

        } 

    }
}