// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string number1 = Convert.ToString(number);

if (number1.Length == 3)
{
    int temp = number % 10;
    Console.WriteLine("Третья цифра числа " + number + " -> " + temp);
}
if (number1.Length > 3)
{
    Console.WriteLine(number + " -> " + number1[2]);
}
else
{
    if (number1.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
}