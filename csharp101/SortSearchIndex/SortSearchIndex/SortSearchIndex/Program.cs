using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSearchIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new List<String> {"Bill", "Scott", "Herman", "Kendra"};

            names.Add("Josh");
            names.Add("Elton");
            names.Remove("Scott");
            Console.WriteLine("Sorting List");
            names.Sort();
  

            foreach (var name in names)
            {
                
                var index = names.IndexOf(name);
                Console.WriteLine($" using names[index] like an array notation: {names[index]}");

                if (index == -1)
                    Console.WriteLine($"{name} not found, index is {index}");
                else
                Console.WriteLine($" Found {name} at index {index}");
            }

            Console.WriteLine("Order by Descending");
            names.Reverse();

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }

            Console.ReadLine();
        }
    }
}
