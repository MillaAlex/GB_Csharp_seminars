// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = 0;

Console.Write($"m = {m}, n = {n} -> A(m,n) = {AckermannFunc(m, n, result)}");

int AckermannFunc(int m, int n, int result)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return AckermannFunc(m - 1, 1, result);
    if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1, result), result);
    return result;
}