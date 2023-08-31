using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности: ");
            int lengthOfNumbers = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0 ; lengthOfNumbers > i ; i++ )
            {
                Console.WriteLine("Введите число: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if( inputNumber < minNumber ) 
                {
                    minNumber = inputNumber;
                }
            }
            Console.WriteLine($"Минимальное число из всей последовательности - {minNumber}");

            Console.ReadKey();
        }
    }
}
