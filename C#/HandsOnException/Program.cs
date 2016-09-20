using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i, j");
            try
            {
                byte i = byte.Parse(Console.ReadLine());
                byte j = byte.Parse(Console.ReadLine());
                int k = i / j;
                Console.WriteLine("Division of {0}/{1} is {2}", i, j, k);
            }
            catch (DivideByZeroException ex)
            {
                //Console.WriteLine("j value should not be zero");
                Console.WriteLine("Message" + ex.Message);
                Console.WriteLine("Assembly Name" +ex.Source);
                Console.WriteLine("Method name" +ex.TargetSite);
                Console.WriteLine("Stack Trace" +ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter only numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch {
                Console.WriteLine("Error Occured");
            }
        }
    }
}
