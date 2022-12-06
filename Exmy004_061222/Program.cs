﻿int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[i])
            {
                int temporary = array[i];
                array[i] = array[j];
                array[j] = temporary;
            }
        }
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

