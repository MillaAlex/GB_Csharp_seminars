// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"{number} ");

int Sum()
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
Console.WriteLine($" -> {(Sum())}");