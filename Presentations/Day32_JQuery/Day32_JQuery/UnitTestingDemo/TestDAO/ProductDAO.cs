using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entity;
namespace TestDAO
{
    public class ProductDAO
    {
        SqlConnection con = new SqlConnection("Data Source=SANTU-PC;Initial Catalog=pubs;Integrated Security=True");
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        public int AddProduct(ProductEntity objEntity)
        {
            cmd=new SqlCommand("Insert into Product values("+objEntity.Pid+",'"+objEntity.Pname+"',"+objEntity.Price+","+objEntity.Stock+")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return 1;

        }
        public ProductEntity GetProduct(int Id)
        {
            ProductEntity objEnity=null;
            da = new SqlDataAdapter("Select * from Product where Pid= " + Id,con);
            ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count>0)
            {
            objEnity= new ProductEntity();
            objEnity.Pid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            objEnity.Pname = ds.Tables[0].Rows[0][1].ToString();
            objEnity.Price = int.Parse(ds.Tables[0].Rows[0][2].ToString());
            objEnity.Stock = int.Parse(ds.Tables[0].Rows[0][3].ToString());
            }
            return objEnity;
        }
    }
}
