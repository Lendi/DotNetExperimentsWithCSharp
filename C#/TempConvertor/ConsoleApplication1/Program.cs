using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempConvertor;

namespace TempConvertor
{
    class program
    {
        static void Main(string[] args)
        {
            temp tp = new temp();
            Console.WriteLine("Ceslius to F " + tp.CTF(67));

        }
    }
}
