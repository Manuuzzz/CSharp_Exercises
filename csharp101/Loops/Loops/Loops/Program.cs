using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int x = 0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"write a line until {length} - for loop");
              
            }
            Console.WriteLine("Type for in visual studio followed by 2*tab, and the code snippet is insterted - you see a box before for");
            Console.ReadLine();

            while (x < 10)
            {
                Console.WriteLine("while 0 to 10");
                x++;
            }
            Console.ReadLine();
        }
    }
}
