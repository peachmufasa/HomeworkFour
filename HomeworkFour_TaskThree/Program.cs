using System;

namespace HomeworkFour_TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное значение диапозона чисел в ваше игре: ");
            int maxValue = int.Parse(Console.ReadLine());
            Random r = new Random();
            int number = r.Next(0, maxValue);

            while(true)
            {
                Console.WriteLine("Введите число: ");
                string userNumber = Console.ReadLine();
                if (String.IsNullOrEmpty(userNumber))
                {
                    Console.WriteLine("Вы решили закончить игру" +
                        $"\nЗагаданное число: {number}");
                    break;
                }
                else 
                {
                    int inputNumber = Convert.ToInt32(userNumber);
                    if (inputNumber > number)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    else if (inputNumber < number)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }
                    else
                    {
                        Console.WriteLine("Вы угадали число");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
