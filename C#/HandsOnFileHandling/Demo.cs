using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFileHandling
{
    class Demo
    {
        public static void WriteMsg(string errmsg) {
            string path = "D:/errlog.txt";
            using (StreamWriter sw = new StreamWriter(path, true)) {
                sw.WriteLine(errmsg);
            }
        }
        public static int Div(byte a, byte b) {
            try
            {
                int c = a / b;
                return c;
            }
            catch (Exception ex) {
                throw ex;
            }        
        }
        static void Main() {
            Console.WriteLine("Enter a and b");
            try
            {
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                Console.WriteLine("Division " + Div(a, b));
            }
            catch (Exception ex) {
                string errmsg = ex.Message + "_" + DateTime.Now + "_" + ex.Source;
                WriteMsg(errmsg);
            }
        
        }
    }
}
