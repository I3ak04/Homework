using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Введите максимальный целое число диапозона: ");
            
            int maxRand = int.Parse(Console.ReadLine());
            int randomNumber = rand.Next(1, maxRand + 1);
            byte tries = 0;

            while (true) 
            {
                
                int inputNumber = int.Parse((Console.ReadLine()));
                
                if(randomNumber == inputNumber)
                {
                    Console.WriteLine($"Вы отгадали, это число - {randomNumber}\nБыло потрачено - {tries} попыток");
                    break;
                }
                else if(randomNumber > inputNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного");
                    tries++;
                }
                else if (randomNumber < inputNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного");
                    tries++;
                }
            }
            Console.ReadKey();
        }
    }
}
