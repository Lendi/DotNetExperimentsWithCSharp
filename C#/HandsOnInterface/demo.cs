using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterface
{
    interface Imobile
    {
        double discount();
    }
    interface Ilaptop
    {
        double discount();
    }
    class Onlineshop: Imobile, Ilaptop
    {
        double Imobile.discount()
        {
            return 1220;
        }
        double Ilaptop.discount()
        {
            return 2200;
        }

        class demo {
            static void Main() {
                Imobile obj = new Onlineshop();
                Console.WriteLine("Mobiles discount:" + obj.discount());
                Ilaptop obj1 = new Onlineshop();
                Console.WriteLine("laptop discount:" +obj1.discount());
            }
        }

    }
}
