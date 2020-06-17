using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ListArraysCollection
{
    class Program
    {

        private static bool testNumber(int i)
        {

            return (i == 7);

        }

        static void Main(string[] args)
        {

           

            var numbers = new List<int> { 1, 2, 3, 5, 7 , 7, 7};

            foreach (var number in numbers) //you can replace var with int here
            {
                Console.WriteLine(number);
                

            }

            numbers.Remove(3);
            numbers.RemoveAll(testNumber);
            foreach (int number in numbers) //you can replace var with int here
            {
               
                Console.WriteLine(number);
                

            }

            Console.ReadLine();


        }
    }
}
