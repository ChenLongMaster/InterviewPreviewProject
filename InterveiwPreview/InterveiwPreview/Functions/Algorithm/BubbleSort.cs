using System;
using System.Collections.Generic;
using System.Text;

namespace InterveiwPreview.Functions.Algorithm
{
    public class BubbleSort
    {
        public int[] sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 0; i < arr.Length - 1 - i; j++)
                {
                    if (arr[i] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[i] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
