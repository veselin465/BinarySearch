using System;

namespace BinarySearch
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 1, 6, 9, 14, 24, 44, 59, 97 };

            int pos1 = BinarySearchPosition(array, 9);
            int pos2 = BinarySearchPosition(array, 10);

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);

        }

        private static int BinarySearchPosition(int[] array, int numberToFind)
        {

            int start = 0, end = array.Length;
            int middle;

            while(end - start > 1)
            {
                middle = (start + end) / 2;
                if (array[middle] == numberToFind)
                    return middle;

                if(array[middle] > numberToFind)
                {
                    end = middle;
                }
                else
                {
                    start = middle;
                }

            }

            if (numberToFind == array[start])
                return start;

            if (numberToFind == array[end])
                return end;

            return -1;

        }
    }
}
