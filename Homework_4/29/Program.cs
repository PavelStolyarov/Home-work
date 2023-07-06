// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray (int[] EmptyArray)
{
    int length = EmptyArray.Length;
    for (int i = 0; i < length; i++)
    {
        EmptyArray[i] = new Random().Next(-10, 40);
    }
}

void PrintArray (int[] FilledArray)
{
    int size = FilledArray.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(FilledArray[i] + " ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);