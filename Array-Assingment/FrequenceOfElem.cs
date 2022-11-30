using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Array_Assingment
{
    class FrequenceOfElem
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int[] frq = new int[arr.Length];
            int visited = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;

                    frq[j] = visited; 
                }
                if (frq[i] != visited)
                    frq[i] = count;
            }

            for(int i = 0; i < frq.Length; i++)
            {
                if(frq[i] != visited)
                    Console.WriteLine(arr[i] + " : " + frq[i]);
            }
        }
    }
}
