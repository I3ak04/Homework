using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int divider = 2;
            bool simple = false;
            while(inputNumber != 1 && inputNumber != divider)
            {
                
                if (inputNumber % divider == 0)
                {
                    Console.WriteLine("Число составное");
                    simple = true;
                    break;
                }
                else
                {
                    divider++;
                }
            }

            if (simple == false) Console.WriteLine("число простое");
            
            

            Console.ReadKey();
        }
    }
}
