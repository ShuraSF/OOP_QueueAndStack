using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ANotherApp
{
    // Многомерные массивы

    // Двумерный прямоугольный массив
    class Program
    {
        static void Main(string[] args)
        {
            // синтаксис такой:
            // тип_данных [,] имя_массива;


            string[,] myArray = new string[2, 3];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    WriteLine($"Y: {i}, X: {j}");
                    myArray[i, j] = (ReadLine());
                }
                WriteLine();
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Write(myArray[y, x] + "\t");
                }
                WriteLine();
            }
            ReadKey();



            /*
                int[] someArray = { 3, 16, 32, 64, 51, 77, 88, 55, 101, 7, 29 };
            
                int[] rangeArray = someArray[2..6];
               
            int[] newArray = new int[3];
            Array.Copy(someArray, 2, newArray, 0, 3);
            Console.WriteLine(string.Join(",", rangeArray.Select(x => x)));
            */

        }

    }
}