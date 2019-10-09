using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numbersOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            while (!numbersOK)
            {
                WriteLine("Note that at least one number must be >10 for the messages to be consistent with the entered scenario.");
                WriteLine("Enter 2 numbers, both numbers cannot be greater than 10.");
                WriteLine("Please enter the first number:");
                var1 = ToDouble(ReadLine());
                WriteLine("Please enter the second number:");
                var2 = ToDouble(ReadLine());
                WriteLine($"The first number entered is {var1} " +
                $"and the second is {var2}");
                if ((var1 > 10) ^ (var2 > 10))
                {
                    numbersOK = true;
                }
                
                else
                {
                    WriteLine("Only one number may be greater than 10, " +
                    "please try again.");
                }
            }
            WriteLine("Press the <ENTER> key to exit.");
            ReadLine();
        }
    }
}
