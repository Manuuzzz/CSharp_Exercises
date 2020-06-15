using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {

        public static void CelsiusToFahrenheit(double temperature)
        {

            double result = (temperature * 1.8) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is {result}");
            Console.ReadLine();
           
        
        }
        static void Main(string[] args)
        {
              Console.WriteLine("Give the temperature in Celsius to convert to Fahrenheit: ");
             double temperature = Convert.ToDouble(Console.ReadLine());

                if (temperature > -271.15)
                {
                    CelsiusToFahrenheit(temperature);
                }
                else
                {
                Console.WriteLine("The temperature is below absolute zero");
               Console.ReadLine();
                }
               

            

        }
    }
}
