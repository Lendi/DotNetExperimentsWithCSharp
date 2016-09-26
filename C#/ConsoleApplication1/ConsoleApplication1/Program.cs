using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sample : Demo { 
    public Sample(){
    //within inherited data, 
        a = 20;
        c = 30;
        d = 3;
        e = 12;        
    
    }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.a = 10;
            obj.d = 20;
            obj.e = 30;
        }
    }
}
