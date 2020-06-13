using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace super
{

    class sampleclass {
        public void samplemethod()
        {

            System.Console.WriteLine("samplemethod string");
        }

    }
}


namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            super.sampleclass outer = new super.sampleclass();
            outer.samplemethod();
            Console.ReadLine();

        }
    }

   

}
