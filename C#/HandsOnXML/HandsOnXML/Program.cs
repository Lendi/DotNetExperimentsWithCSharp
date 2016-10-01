using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HandsOnXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\DotNetExperimentsWithCSharp\C#\HandsOnXML\HandsOnXML\product.xml";
            XmlReader obj = XmlReader.Create(path);//xml doesnt have public constructor, which isnt letting us to
            //create objects
            while (obj.Read())
            {
                Console.WriteLine(obj.Name);
                if (obj.NodeType == XmlNodeType.Element) {
                    obj.Read();
                    Console.Write(obj.Value);
                }
            }
        }
    }
}
