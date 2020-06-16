using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_if
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            int c = 4;
            int ans = a + b + c;
            if (a + b +c >= 10 && a == b){

                Console.WriteLine($"The answer {ans} is >= 10 and a ({a}) == b ({b})");
                Console.ReadLine();
            }

            else
            {

                Console.WriteLine($"The answer {ans} is not >= 10 and / or  a ({a}) != b ({b})");
                Console.ReadLine();
            }
        }
    }
}
