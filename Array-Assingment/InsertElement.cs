using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class InsertElement
    {
        static void Main(string[] args)
        {
            int[] arr = new int[40];

            Console.Write("Enter the Size of Array : ");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Elements of Array : ");

            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Number to Insert : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Index Value : ");
            int index = int.Parse(Console.ReadLine());

            int j = s - 1; ;
            for(int i = 0; i < s; i++)
            {
                while (j >= index)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
            }
            arr[index] = x;
            s++;

            Console.WriteLine("New Array : ");
            for(int i=0; i < s; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
