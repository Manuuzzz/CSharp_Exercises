using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_consoleapp_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //comand line arguments are given in the properties of the solution - debug window

            Console.WriteLine($"This application took {args.Length} arguments");
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg}");
            }
            Console.ReadKey();
        }
    }
}
