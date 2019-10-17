using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Functions_ParameterArrays
{
    class Program
    {
        static int SumVal(params int[] numberList)
        {

            int sum = 0;
            foreach(int number in numberList){

                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6 };
            int result;
            result = SumVal(numbers);
            Console.WriteLine($"The sum of all numbes is {result}");
            Console.ReadKey();
        }
    }
}
