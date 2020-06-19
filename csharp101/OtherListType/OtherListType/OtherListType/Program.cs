using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherListType
{
    class Program
    {
        static void Main(string[] args)
        {

            var fibonaccilist = new List<int> { 1, 1 };

            Console.WriteLine("Output the fibonacci sequence up to 676;");

            while (fibonaccilist.Count < 20)
            {

                var previous = fibonaccilist[fibonaccilist.Count - 1];
                var previous2 = fibonaccilist[fibonaccilist.Count - 2];

                fibonaccilist.Add(previous + previous2);

            }

            foreach (var number in fibonaccilist)
            {

                Console.WriteLine(number);
               

            }

            Console.ReadLine();
        }
    }
}
