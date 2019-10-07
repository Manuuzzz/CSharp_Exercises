using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            string myString = "\"My String is\" ";
            double firstNumber, secondNumber;
            Console.WriteLine($"{ myString} {myInt}\n");
          
            int var1, var2 = 5, var3 = 6;
            var1 = var2++ * --var3;
            Console.WriteLine($"{var1}\n");

            Console.WriteLine("\nGive your first number");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nGive your second number");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Sum is {firstNumber + secondNumber}");
            Console.WriteLine($"Subtraction is {firstNumber - secondNumber}");
            Console.WriteLine($"Product is {firstNumber * secondNumber}");
            Console.WriteLine($"Divide is {firstNumber / secondNumber}");
            Console.WriteLine($"Remainder is {firstNumber % secondNumber}");
            Console.ReadKey();
            double resultVar, var4, var5, var6, var7, var8;
            var4 = 2;
            var5 = 3;
            var6 = 4;
            var7 = 8;
            var8 = 9;

            resultVar += var4 * var5 + var6 % var7 / var8;

        }   
    }
}
