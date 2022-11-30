using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class SecondMax
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 50, 80, 40, 50 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }else if(arr[i]>secondMax && arr[i] != max)
                {
                    secondMax = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Second Maximum : " + secondMax);
        }
    }
}
