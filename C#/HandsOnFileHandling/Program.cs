using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOnFileHandling
{
    class Program
    {
        public static void ReadData(string path) {
            StreamReader obj = new StreamReader(path);
            string content = obj.ReadToEnd();
            Console.WriteLine(content);

        }

        public static void WriteData(string path) {
            using (StreamWriter obj = new StreamWriter(path)){
            string content = ".NET is a product of MS";
            obj.WriteLine(content);


        }
            
        }


        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter Path");
                string path = Console.ReadLine();
                //ReadData(path);
                WriteData(path);

            
            

        }
    }
}
