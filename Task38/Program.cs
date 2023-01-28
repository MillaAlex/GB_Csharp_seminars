/* 
Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

int[] array = new int[10];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b");
}
Console.Write("] -> ");

int FindMin(int[] array)
{
    int index = 0;
    int min = array[index];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
FindMin(array);

int FindMax(int[] array)
{
    int index = 0;
    int max = array[index];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
FindMax(array);

int dif = (FindMax(array)) - (FindMin(array));
Console.WriteLine(dif);
