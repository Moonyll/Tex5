using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
         string[] numbers = new string[] { "", "2", "3", "4", "5", "6", "" };
         for (int i = 0; i < numbers.Length; i++)
         Console.WriteLine(numbers[i]);
         Console.ReadKey();
         numbers[0] = "1";
         numbers[6] = "7";
         for (int i = 0; i < numbers.Length; i++)
         Console.WriteLine(numbers[i]);
         Console.ReadKey();

        }
    }
}
