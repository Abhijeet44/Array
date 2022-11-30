using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class MisiingNum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5 , 6, 7, 8, 9 };

            for(int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] + 1 != arr[i + 1])
                {
                    Console.WriteLine("Missing Number is : " + (i+2));
                }
            }
        }
    }
}
