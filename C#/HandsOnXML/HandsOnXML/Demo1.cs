using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HandsOnXML
{
    class Demo1
    {
        static void Main() {
            string path = @"D:\DotNetExperimentsWithCSharp\C#\HandsOnXML\HandsOnXML\product.xml";
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            foreach(DataRow r in ds.Tables[0].Rows){
                Console.WriteLine("{0}  {1}  {2}  {3}  ", r[0], r[1], r[2], r[3]);
            }
        }
    }
}
