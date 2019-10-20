using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Functions_OutParameters
{
    class Program
    {
        static int MaxValue(int[] numberList, out int index)
        {
            int maxValue = 0;
            index = 0;
            for (int i = 0; i < numberList.Length; i++)
            {
               
                if (numberList[i] > maxValue)
                {
                    maxValue = numberList[i];
                    index = i;
                }

            }
            return maxValue;
       
        }
        static void Main(string[] args)
        {
            int[] numberlist = { 1, 5, 3, 8, 9, 4 };
            int highestValue = MaxValue(numberlist, out int index);
            Console.WriteLine($"The highest number of the array is {highestValue}, and is located at element {index+1}");
            Console.ReadKey();
        }
    }
}
