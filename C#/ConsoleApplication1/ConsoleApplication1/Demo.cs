using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Demo
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        //whats the diff btw internal and protected internal
        //diff asembly, in inherited class, both can be accessed
        //same assembly, using object proteced cant bee accessed, but public and protected internal is accessible

    }
}
