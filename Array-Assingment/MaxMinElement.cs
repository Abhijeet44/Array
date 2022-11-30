using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class MaxMinElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Size : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Array is: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            int min = arr[0];

            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("\nMaximum : " + max);
            Console.WriteLine("Minimum : " + min);

        }
    }
}
