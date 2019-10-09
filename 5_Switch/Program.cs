using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "benjamin";
            const string niceName = "jean";
            const string sillyName = "goofy";

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            switch (yourName.ToLower())
            {
                case myName: 
                    Console.WriteLine("We have the same name");
                    break;
                
                case niceName:
                    Console.WriteLine("You have a nice name");
                    break;

                case sillyName:
                    Console.WriteLine("You have a silly name");
                    break;
            }

            Console.WriteLine($"Hello {yourName}!");
            Console.ReadKey();
        }
    }
}
