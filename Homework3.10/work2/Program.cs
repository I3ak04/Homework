using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую вас в игре \"21\"\nВведите число карт в руке:");
            
            byte cardsOnHand = byte.Parse(Console.ReadLine());
            int sum = 0;
            
            Console.WriteLine("Введите номинал каждой карты\n\nДля карт с картинкой следующие значения (Вводить заглавные)\nВалет = J\nДама = Q\nКороль = K\nТуз = T");
            for(byte i = 0 ; cardsOnHand > i ; i++ )
            {
                string cardRating = Console.ReadLine();
                

                switch (cardRating)
                {
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Введено неправильное значение");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"Сумма всех карт - {sum}");
            Console.ReadKey();
        }
    }
}
