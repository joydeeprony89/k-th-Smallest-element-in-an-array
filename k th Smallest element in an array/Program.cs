﻿using System;

namespace k_th_Smallest_element_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, -1, -2, 9 };
            int k = 1;
            Console.Write("K'th largest element is " + FindKthSmallest(arr, k));
        }


        static int FindKthSmallest(int[] nums, int k)
        {
            int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int position = Partition(nums, l, r);
                if (k < position)
                {
                    r = position - 1;
                }
                else if (k > position)
                {
                    l = position + 1;
                }
                else break;
            }
            return nums[k - 1];
        }


        static int Partition(int[] nums, int l, int r)
        {
            int i = l;
            int pivot = nums[r];
            for (int j = l; j < r; j++)
            {
                if (nums[j] <= pivot)
                {
                    Swap(nums, i, j);
                    i++;
                }
            }
            Swap(nums, i, r);
            return i;
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
