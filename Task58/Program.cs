// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr1 = new int[2, 2] {{2,4}, {3,2}};

int[,] arr2 = new int[2, 2] {{3,4}, {3,3}};

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j], 4}");
        }
        Console.WriteLine();
    }
}
PrintArr(arr1);
Console.WriteLine();
PrintArr(arr2);

Console.WriteLine("Result:");

void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int rowArr1 = arr1.GetLength(0);
    int colArr1 = arr1.GetLength(1);
    int rowArr2 = arr2.GetLength(0);
    int colArr2 = arr2.GetLength(1);
    int temp = 0;
    int[,] bothArrays = new int[rowArr1, colArr2];
    {
        for (int i = 0; i < rowArr1; i++)
        {
            for (int j = 0; j < colArr2; j++)
            {
                for (int k = 0; k < colArr2; k++)
                {
                    temp += arr1[i,k] * arr2[k,j];
                }
                bothArrays[i,j] = temp;
                temp = 0;
                Console.Write($"{bothArrays[i, j], 4}");
            }
            Console.WriteLine();
        }
        
    }
}
MultiplyArrays(arr1, arr2);

