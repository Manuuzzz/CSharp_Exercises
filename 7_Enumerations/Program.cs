using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Enumerations
{
    enum orientation : byte
    {
    north= 1,
    east=2,
    south= 3,
    west= 4

    }
    class Program
    {
        static void Main(string[] args)
        {
            orientation myOrientation = orientation.north;
            Console.WriteLine($"My orientation is {myOrientation}");
            Console.ReadKey();
       
        }
    }
}
