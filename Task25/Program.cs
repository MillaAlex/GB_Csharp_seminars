// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int numB = int.Parse(Console.ReadLine());

int PowOfNumber()
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}
Console.Write($"Число {numA} в степени {numB} -> {(PowOfNumber())}");

