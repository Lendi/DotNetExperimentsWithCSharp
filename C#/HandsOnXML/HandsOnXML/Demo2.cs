using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HandsOnXML
{
    class Demo2
    {
        static void Main()
        {
            string path = @"D:\DotNetExperimentsWithCSharp\C#\HandsOnXML\HandsOnXML\product.xml";
            XmlDocument obj = new XmlDocument();
            obj.Load(path);
            //obj.Save(Console.Out);
            //obj.Save("D:/text.xml");
            //read product names
            XmlNodeList list = obj.SelectNodes("products/product/pname");
            foreach(XmlNode n in list ){
                Console.WriteLine(n.InnerText);
            }
            Console.Clear();
            //read all products
            XmlNodeList list1 = obj.SelectNodes("products/product");
            foreach (XmlNode n in list1) {
                //Console.WriteLine(n.ChildNodes[0].InnerText);
                Console.WriteLine(n.ChildNodes[0].InnerText);
                //Console.WriteLine(n.ChildNodes[1].InnerText);
            }
        }
    }
}
