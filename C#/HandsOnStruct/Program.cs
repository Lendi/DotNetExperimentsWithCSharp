using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace HandsOnStruct
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/

struct Box{


public int width;
    public int height;


    public Box(int w, int h){
    width = w;
    height = h;}

    static void Main(){
    Box b = new Box(12, 13);
        Console.WriteLine(b.height);
        Console.WriteLine(b.width);
    }

}