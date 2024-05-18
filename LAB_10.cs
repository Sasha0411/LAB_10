using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Горкун Олександр");

            // Розмір матриці
            const int size = 10;

            // Створення матриці
            int[,] matrix = new int[size, size];
            Random random = new Random();

            // Заповнення матриці випадковими числами
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(20);
                }
            }

            // Виведення матриці на екран
            Console.WriteLine("Сформована матриця:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // Підрахунок елементів, що відповідають умові
            int[] elementCounts = new int[size];
            for (int j = 0; j < size; j++)
            {
                elementCounts[j] = 0;
                for (int i = 0; i < size; i++)
                {
                    if (matrix[i, j] >= 0 && matrix[i, j] < 20)
                    {
                        elementCounts[j]++;
                    }
                }
            }

            // Виведення результатів підрахунку
            Console.WriteLine("\nКількість елементів у стовпцях, що відповідають умові:");
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine("Стовпець {0}: {1}", j + 1, elementCounts[j]);
            }
        }
    }
}
