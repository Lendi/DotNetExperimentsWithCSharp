using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate1(int i);

    class Demo1
    {
        public void Task() {
            Console.WriteLine("do something..");
            Console.WriteLine("do something..");
            Console.WriteLine("do something..");
            Console.WriteLine("do something..");
        
        }

        public void M1(int i) {
            for (int k = 0; k <= i; k++) {
                Console.WriteLine("Printing M1 method");
            }
        
        }
        static void Main() {
            Demo1 d = new Demo1();
            //instantiate delegate
            MyDelegate _myob = new MyDelegate(d.Task);
            //invoking delegate
            _myob();
            Console.Clear();

            MyDelegate1 _myob1 = new MyDelegate1(d.M1);
            _myob1(10);
            Console.WriteLine();
            _myob1.BeginInvoke(5, null, null); //to run asynchronously

        
        }
    }
}
