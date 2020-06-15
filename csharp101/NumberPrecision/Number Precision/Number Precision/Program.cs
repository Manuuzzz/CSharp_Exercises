using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Precision
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            double maxValueDouble = double.MaxValue;
            double minValueDouble = double.MinValue;

            Console.WriteLine($"The range of integers is from {minValue} to {maxValue}");
            Console.WriteLine($"The range of integers is from {minValueDouble} to {maxValueDouble}");

            int a = 6;
            int b = 7;
            int c = 3;

            int int_ans = (a + b) / c;

            double d = 6;
            double e = 7;
            double f = 3;

            double double_ans = (d + e) / f;
            Console.WriteLine($"(6+7)/3={int_ans} - calculation with integers");
            Console.WriteLine($"(6+7)/3={double_ans} - calculation with double");
            Console.ReadLine();
        }
    }
}
