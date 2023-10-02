//*******************************************************************
//* Практическая работа №8                                          *
//* Выполнил: Онищенко В.И., группа 2ИСП                            *
//* Сставление  программ циклической структуры: итерационные циклы *
//*******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Практическая работа №8. \nЗдравствуйте! ");
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine()); // исходное число - number

                int reverseNumber = 0;
                while (number > 0)
                {
                    int digit = number % 10; // Получение последней цифры числа 
                    reverseNumber = reverseNumber * 10 + digit; // Добавление цифры в перевертыш 
                    number /= 10; // Удаление последней цифры числа 
                }

                Console.WriteLine("Перевертыш числа: " + reverseNumber);

            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вышла какая-то ошибка: " + fe.Message);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вышла какая-то ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
    

