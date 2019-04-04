using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();

            Console.WriteLine("Please enter your favorive music band1");
            string band1 = Console.ReadLine();

            Console.WriteLine("Please enter your favoruve music band2");
            string band2 = Console.ReadLine();

            string sentence = $"Hello { name}! I am { age} My are your favorite bands{band1} {band2}";
            Console.WriteLine(sentence);
            Console.ReadLine();






        }
    }
}






