using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject._2D_Array
{
    class VaryingColumn 
    {
        // Rows are Fixed Columns are Varying

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Columns : ");
            int c = int.Parse(Console.ReadLine());

            int[,] arr = new int[3,c];

            for(int i = 0; i <arr.GetLength(0); i++)
            {
                for(int j = 0; j <arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
