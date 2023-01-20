// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Вариант 1 (не работает с отрицательными):

// Console.Write("Введите положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string number1 = Convert.ToString(number);

// if (number1.Length == 3)
// {
//     int temp = number % 10;
//     Console.WriteLine("Третья цифра числа " + number + " -> " + temp);
// }
// if (number1.Length > 3)
// {
//     Console.WriteLine(number + " -> " + number1[2]);  
// }
// else
// {
//     if (number1.Length < 3)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
// }

// Вариант 2:

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10)
// т.к. в условии не сказано, что делать с отрицательными и с однозначным числом 
{
    Console.WriteLine("Недопустимое число");
}
else if (number > 99 & number <= 999)
{
    int thirdnumber = number % 10;
    Console.WriteLine("Третья цифра числа " + number + " -> " + thirdnumber);
}
else if (number > 9 & number <= 99)
{
    Console.WriteLine(number + " - > третьей цифры нет");
}
else if (number > 999)
{
    string bignumber = Convert.ToString(number);
    Console.WriteLine("Третья цифра числа " + number + " -> " + bignumber[2]);
}