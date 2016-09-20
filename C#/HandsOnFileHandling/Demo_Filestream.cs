using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnFileHandling
{
    class Demo_Filestream
    {
        public static string Read(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                try
                {

                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, (int)fs.Length);
                    //foreach (byte b in data) {
                    //    Console.Write(b);

                    //convert byte array into string

                    string content = new UTF8Encoding().GetString(data);
                    return content;

                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
        }


        public static void Write(string path) {
            string content = "Monday is a holiday.";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)) {
                byte[] data = new UTF8Encoding().GetBytes(content);
                fs.Seek(0, SeekOrigin.End);
                fs.Write(data, 0, data.Length);
            }
        }

        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Filepath");
                string path = Console.ReadLine();
                //Console.WriteLine(Read(path));
                Write(path);

            }
            catch (IOException ex) {

                throw ex;

            }

             //Console.WriteLine(content);

            //avoid writing writeline methods inside methods
        }
    }
      
    }

