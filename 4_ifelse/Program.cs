using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            double number_1, number_2;
            Console.WriteLine("Give your first number: ");
            number_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give your second number: ");
            number_2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            if (number_1 < number_2)
            
                Console.WriteLine($"{number_1} is smaller then {number_2}");
             else
            {
                if (number_1 == number_2)
                
                    Console.WriteLine($"{number_1} is equal to {number_2}");
                
                else 
                
                    Console.WriteLine($"{number_1} is greater than {number_2}");
                
            }
            Console.ReadKey();
        }
    }
}
