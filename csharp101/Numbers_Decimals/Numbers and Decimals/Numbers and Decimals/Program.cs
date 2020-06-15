using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_and_Decimals
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = 3.0M;
            decimal b = 1.7M;

            decimal ans = a / b;

            Console.WriteLine($"3.0 / 1.7 = {ans}");
            Console.WriteLine("Check the documentation for the type you need: int, double, long, short, decimal, ..");

            double test1 = 2.5723;
            double test2 = 2.5614;
            double test = test1 / test2;
            Console.WriteLine($"test = {test}");
            Console.ReadLine();

            decimal test3 = 2.5723M;
            decimal test4 = 2.5614M;
            decimal test5 = test3 / test4;
            Console.WriteLine($"test = {test5}");
            Console.ReadLine();


            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area = {area}");
            Console.ReadLine();

            


        }
    }
}
