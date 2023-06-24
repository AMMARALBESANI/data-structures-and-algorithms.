using System;

namespace challenge_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(bisercher(array, 8));
        }

        public static int bisercher(int[] array, int search)
        {
            int begining = 0;
            int end = array.Length - 1;

            while (begining <= end)
            {
                int midlle = begining + (end - begining) / 2;

                if (array[midlle] == search)
                {
                    return midlle;
                }

                if (array[midlle] < search)
                {
                    begining = midlle + 1;
                }
                else
                {
                    end = midlle - 1;
                }
            }

            return -1; 
        }
    }
}
