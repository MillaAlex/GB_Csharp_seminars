// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
FillArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 4} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);

int SumOfRows(int[,] array, int i)
{
    int sumOfRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumOfRow += array[i, j];
    }
    Console.WriteLine($"Строка №{i + 1}: сумма элементов {sumOfRow}.");
    return sumOfRow;
}

int minSumRow = 0;
int sumOfRow = SumOfRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumOfRows(array, i);
    if (sumOfRow > temp) 
    {
        sumOfRow = temp;
        minSumRow = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}, сумма элементов {sumOfRow}.");
