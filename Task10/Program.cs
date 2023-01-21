// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string number1 = Convert.ToString(number);

if (number1.Length == 3)
{
    int temp = number / 10;
    int secondnumber = temp % 10;
    Console.WriteLine("Вторая цифра числа " + number + " -> " + secondnumber);
}
else Console.WriteLine("Недопустимое число");