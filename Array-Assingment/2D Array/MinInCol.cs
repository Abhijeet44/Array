using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2D_Array
{
    class MinInCol
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("--------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            for (int i = 0; i < 3; i++)
            {
                int min = arr[0, i];
                for (int j = 1; j < 3; j++)
                {
                    if (arr[j, i] < min)
                        min = arr[j, i];
                }
                Console.WriteLine(min);
            }
        }
    }
}
