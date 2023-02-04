// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

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
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void Check(int[,] array)
{
    Console.Write("Введите индекс строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{i}, {j} -> ");
    if (i <= array.GetLength(0) && j <= array.GetLength(1)) Console.Write(array[i, j]);
    else Console.Write("такого числа в массиве нет");
}
Check(array);