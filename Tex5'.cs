using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadKey();
            numbers.Insert(0, 1);
            numbers.Insert(6, 7);
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadKey();

        }
    }
}
