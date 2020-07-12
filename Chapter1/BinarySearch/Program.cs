using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_list = {1,3,5,7,9}; 
            Console.WriteLine(binary_search(my_list, 3));
        }

        public static int binary_search(int[] list, int item)
        {
            var low = 0;
            var high = list.Length - 1;
            {
                
            }; 
            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list[mid];
                if (guess == item)
                {
                    return mid; 
                }
                else if(guess > item)
                {
                    high = mid -1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return 0; 
        }
    }
}
