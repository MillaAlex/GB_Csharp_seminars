// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("b1 = ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("k1 = ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("b2 = ");
float b2 = float.Parse(Console.ReadLine());
Console.Write("k2 = ");
float k2 = float.Parse(Console.ReadLine());

void LinesCrossPoint(float b1, float k1, float b2, float k2)
{
    float x = (b2 - b1) / (k1 - k2);
    float y = (k1 * x) + b1;
    if (k1 == k2 && b1 == b2) Console.Write("Прямые совпадают");
    else Console.Write($"Точка пересечения заданных прямых -> ({x}; {y})");
}
LinesCrossPoint(b1, k1, b2, k2);



