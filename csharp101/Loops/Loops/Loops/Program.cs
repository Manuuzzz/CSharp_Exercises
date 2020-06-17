using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

            //print all integers from 1 to 20 that are divisible by 3 - combine loops and branches

            int sum = 0;

            for (int z = 0; z <=20; z++)
            {
                
                if (z % 3 == 0)
                {

                    Console.WriteLine($"{z} is divisible by 3");
                    sum = sum + z;
                 
                }

                else
                {

                    Console.WriteLine($"{z} is not divisible by 3");
                    
                }
                Console.WriteLine($"sum is {sum}");
               
            }
            Console.ReadLine();
        }
    }
}
