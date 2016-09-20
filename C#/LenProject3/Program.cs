using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //implicit conversions 
            byte b = 100;
            int i = b;
            double d = b;
            //reverse of above is explicit conversion - larger data types into smaller data type
            


            //explicit using casting
            int i = 100;
            byte b = (byte)i;
            short s = (short)i;
            char ch = (char)i;
            //
            Console.WriteLine(ch);
            Console.ReadKey();

            double d = 12.34;
            i = (int)d;
            long l = (long)d;
             
             */



            //boxing and unboxing 

            object o = 10;
            object o1 = "xbasdg";
            object o3 = 12.45;
            object o4 = true;
            //boxing 
            int i = 100;
            object k = i;
            double d = 23.21;
            object k1 = d;
            //converting object to int, double etc is unboxing

            //unboxing
            object e = 78;
            //int i = e; error cant implicitly convert to object
            int j = (int)o;

            
        }
    }
}

//solution file not created for this project