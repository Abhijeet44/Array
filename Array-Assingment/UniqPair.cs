using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class UniqPair
    {
        static bool isAlreadyPr(int[] a, int curent)
        {
            for (int i = 0; i < curent; i++)
            {
                if (a[i] == a[curent])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };

            Console.WriteLine("Enter The sum : ");
            int sum = int.Parse(Console.ReadLine());

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (isAlreadyPr(arr, j) == false)
                    {
                        if (arr[i] + arr[j] == sum)
                        {
                            Console.WriteLine("(" + arr[i] + "," + arr[j] + ")");
                        }
                    }
                }
            }
        }
    }
}
