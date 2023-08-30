using System;

namespace CodeChallenge26
{
    public class Program
    {
         static void Main(string[] args)
        {

            int[] array = { 8, 4, 23, 42, 16, 15 };


            Console.WriteLine("Original array:");
            PrintArray(array);


            InsertionSort(array);


            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }


        public static void InsertionSort(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {

                int current = array[i];


                int j = i - 1;


                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];


                    j--;
                }


                array[j + 1] = current;
            }
        }


        public static void PrintArray(int[] array)
        {

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
