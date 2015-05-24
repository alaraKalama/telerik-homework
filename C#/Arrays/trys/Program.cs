using System;

public class QuickSortProblem
{
    static void Main()
    {
        int[] numbers = { 8, 7, 2, 3, 4 };
        QuickSort(numbers, 0, numbers.Length - 1);
        Console.WriteLine(String.Join(", ", numbers));
    }

    static void QuickSort(int[] numbers, int start, int end)
    {
        if (start < end)
        {
            int pivot = numbers[end];
            int wallIndex = start;

            for (int i = start; i < end; i++)
            {
                if (numbers[i] <= pivot)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[wallIndex];
                    numbers[wallIndex] = temp;

                    wallIndex++;
                }
            }

            numbers[end] = numbers[wallIndex];
            numbers[wallIndex] = pivot;

            QuickSort(numbers, start, wallIndex - 1);
            QuickSort(numbers, wallIndex + 1, end);
        }

       
    }
    
}