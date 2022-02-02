using System;

namespace HomeworkFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в матрице: ");
            int rowNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите количество столбцов в матрице: ");
            int columnNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix  = new int[rowNum, columnNum];
            
            Random r = new Random();
            
            int matrixsum = 0;

            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < columnNum; j++)
                {
                    matrix[i, j] = r.Next(-100, 100);
                    Console.Write($"{matrix[i, j]} ");
                    matrixsum += matrix[i, j];
                }
                Console.WriteLine();
                
            }
            Console.WriteLine($"\nСумма элементов матрицы = {matrixsum}");
            Console.ReadKey();

        }
    }
}
