using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames= { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;

            Console.WriteLine($"Here are my {friendNames.Length} friends:");
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine($"This is {friendNames[i]}");

            }
            Console.ReadKey();
        }
    }
}
