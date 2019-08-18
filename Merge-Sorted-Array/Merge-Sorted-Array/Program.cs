using System;

namespace Merge_Sorted_Array
{
    class Program
    {
        static int[] mergeSortedArray(ref int[] array1, int size1, ref int[] array2, int size2)
        {
            int size = size1 + size2;
            int[] merge = new int[size];

            for (int i = 0; i < size1; i++)
            {
                merge[i] = array1[i];
            }

            for (int i = 0, k = size1; k < size && i < size2; i++, k++)
            {
                merge[k] = array2[i];
            }

            Array.Sort(merge);
            /*
            int temp;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < (size - i - 1); j++)
                {
                    if  (merge[j] > merge[j+i])
                    {
                        temp = merge[j];
                        merge[j] = merge[j + 1];
                        merge[j + 1] = temp;
                    }
                }
            }*/

            return merge;
        }

        static void display(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 6, 8 };
            int[] b = { 3, 5, 5, 10 };


            int[] merge = mergeSortedArray(ref a, a.Length, ref b, b.Length);

            display(merge);
        }
    }
}
