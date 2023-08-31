using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int inputNumbers = int.Parse(Console.ReadLine());

            if (inputNumbers % 2 == 0)
                Console.WriteLine($"Число {inputNumbers} четное");
            else
                Console.WriteLine($"Число {inputNumbers} нечетное ");

            Console.ReadKey();
        }
    }
}
