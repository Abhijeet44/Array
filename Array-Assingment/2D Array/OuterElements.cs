using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2D_Array
{
    class OuterElements
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];

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

            Console.WriteLine("--------------------\nOuter Elements : ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i * j == 0 || i * j == 3 || i * j == 6 || i * j == 9)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
