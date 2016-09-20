using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Console_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            compute obj = new compute();
            Console.WriteLine("Addition " + obj.Add(6, 8));
            try
            {
                Console.WriteLine("division " + obj.Div(12, 2));
            }
            catch( Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
            message m = new message();
            Console.WriteLine(m.Greet(" rithika"));
        }
    }
}
