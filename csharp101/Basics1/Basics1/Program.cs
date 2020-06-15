using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basics1
{
    class Program
    {
        public static void AddAndMultiply(double x, double y, double z)
        {
        
            Console.WriteLine($"Result: {(x+y)*z}");
            Console.ReadLine();


        }
        static void Main(string[] args)
        {

            double x, y, z;
            Console.WriteLine("Enter 3 numbers:");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());

            AddAndMultiply(x, y, z);


        }
    }
}
