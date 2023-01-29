/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[10];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int QtyOfEven()
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] % 2 == 0) counter += 1;
    }
    return counter;
}
Console.Write($"{QtyOfEven()}");


// int counter = 0;
// for (int i = 0; i < array.Length; i++)
// {   
//     if (array[i] % 2 == 0) counter += 1;
// }
// Console.Write(counter);
