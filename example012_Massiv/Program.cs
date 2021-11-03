int[] arr = { 1, 3, 7, 8, 4, 2, 3, 22, 18, 9, 0 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
Console.WriteLine();

void SelectionSort01(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;

    }
}

PrintArray(arr);
SelectionSort01(arr);

PrintArray(arr);