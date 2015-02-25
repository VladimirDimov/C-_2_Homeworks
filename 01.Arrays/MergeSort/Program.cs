
//Problem 13.* Merge sort

//    Write a program that sorts an array of integers using the Merge sort algorithm.


using System;

class MergeSort
{
    static void Main()
    {
        int[] array = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        Console.WriteLine("MergeSort By Recursive Method");

        Sort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if(i == array.Length - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(", ");
            }
        }
    }

    public static void Sort(int[] array, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            Sort(array, left, mid);
            Sort(array, (mid + 1), right);
            DoMerge(array, left, (mid + 1), right);
        }
    }

    private static void DoMerge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (array[left] <= array[mid])
            {
                temp[tmp_pos++] = array[left++];
            }
            else
            {
                temp[tmp_pos++] = array[mid++];
            }
        }

        while (left <= left_end)
        {
            temp[tmp_pos++] = array[left++];
        }

        while (mid <= right)
        {
            temp[tmp_pos++] = array[mid++];
        }

        for (i = 0; i < num_elements; i++)
        {
            array[right] = temp[right];
            right--;
        }
    }
}

