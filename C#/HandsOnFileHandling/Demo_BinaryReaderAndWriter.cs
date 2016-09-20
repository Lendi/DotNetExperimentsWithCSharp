using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOnFileHandling
{
    class Demo_BinaryReaderAndWriter
    {
        public static void Read(string path) {

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader obj = new BinaryReader(fs);
                byte[] data = new byte[fs.Length];
                obj.Read(data, 0, (int)fs.Length);

                Console.WriteLine(new UTF8Encoding().GetString(data));
            }
        }

        public static void Write(string path) {

            string content = "Monday is a holiday.";
            using (FileStream sw = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)) {
                BinaryWriter obj = new BinaryWriter(sw);
                //byte[] data = new byte[sw.Length];
                byte[] data = new UTF8Encoding().GetBytes(content);
                sw.Seek(0, SeekOrigin.Current);
                sw.Write(data, 0, data.Length);


            
            }

            //public StreamWriter(string path, bool append, Encoding encoding);
        }

        public static void Main() {
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();
            //Read(path);

            Write(path);
        
        }
    }
}
