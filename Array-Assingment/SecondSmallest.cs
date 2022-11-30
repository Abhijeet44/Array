using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class SecondSmallest
    {
        static void Main(string[] args)
        {

            int secondSmall = 0;

            int[] arr = { 4, 3, 2, 6, 8, 9, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    while (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                secondSmall = arr[1];
            }
            Console.WriteLine("Second Smallest : " + secondSmall);
        }
    }
}
