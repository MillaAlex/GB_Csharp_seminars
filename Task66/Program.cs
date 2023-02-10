// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

//int count = 0;
int sum = 0;

Console.Write($"M = {M}; N = {N} -> {SumNumbers(M, N, sum)}");

int SumNumbers(int M, int N, int sum)
{
    if (M == N) return sum + N;
    sum += M;
    M++;
    return (SumNumbers(M, N, sum));
}
