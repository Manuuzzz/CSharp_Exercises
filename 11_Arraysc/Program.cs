using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Arraysc
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello man";
            char[] myChars = myString.ToCharArray();

            foreach (char character in myChars)
            {
                Console.WriteLine($"{character} ");

            }
            Console.WriteLine($"{myChars[4]}");
            Console.ReadKey();   
        }
        
    }
}
