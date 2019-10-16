using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Functions
{
    class Program
    {
        static int MaxValue(int[] myArray)
        {
            int MaxValue = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > MaxValue)
                    MaxValue = myArray[i];

            }
            return MaxValue;

        }
        static void Write()
        {
            Console.WriteLine("This function writes to the console");
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int maxValue = 0;
            maxValue = MaxValue(myArray);

            Write();
            Console.WriteLine($"The maxvalue of the array is {maxValue}");
            Console.ReadKey();
        }
    }
}
