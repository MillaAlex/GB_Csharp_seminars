// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
PrintArray(array);
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
double[] Average(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average[j] += array[i, j];
        }
        average[j] /= array.GetLength(0);
    }
    return average;
}
Average(array);

double[] average = Average(array);

void PrintNewArray(double[] average)
{
    for (var i = 0; i < average.Length; i++)
    {
        Console.Write($"{Math.Round((average[i]),2)}; ");
    }
    Console.Write("\b\b");
    Console.Write(".");
}
Console.Write("Среднее арифметическое каждого столбца: ");
PrintNewArray(average);
