using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Class7
    {

        static void Main() { 
        int[] a = { 4 , 6, 7, 54, 34, 12, 65};
        Console.WriteLine("Dimension" + a.Rank);
        Array.Sort(a);


        int[] b = new int[3];
        Array.Copy(a, b, 3);
        foreach (int k in b)
            Console.WriteLine(k);
        Console.WriteLine("Enter number");
        int no = int.Parse(Console.ReadLine());

        if (Array.BinarySearch(a, no) >= 0)
            Console.WriteLine("Exist");
        else
            Console.WriteLine("Doesnt exist");

        Console.ReadKey();
        }
    }
}
