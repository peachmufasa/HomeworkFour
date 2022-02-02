using System;

namespace HomeworkFour_TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов последовательности: ");
            int elementNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int [elementNumber];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Введите целое число: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\nВаша последовательность:");
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }

            int minValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine($"\n\nМинимальное число в последовательности: {minValue}");
        }
    }
}
