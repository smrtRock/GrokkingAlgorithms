using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5, 3, 6, 2, 10};
        
            SelectionSort(arr);
        }
    
    static int FindSmallest(int[] arr)
    {
        var smallest = arr[0];
        var smallest_index = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                smallest_index = i;
            }
        }
        return smallest_index;
    }
    static void SelectionSort(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var smallest = FindSmallest(arr); 
            newArr[i] = smallest;
            Console.Write($"{newArr[i]} ");
        }
        
    }
}
}

/*

def selectionSort(arr):
    newArr = []
    for i in range(len(arr)):
        smallest = findSmallest(arr)
        newArr.append(arr.pop(smallest))
    return newArr

print(selectionSort([5, 3, 6, 2, 10]))
*/