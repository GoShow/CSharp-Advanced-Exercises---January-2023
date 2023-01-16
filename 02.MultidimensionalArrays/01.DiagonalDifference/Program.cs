using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n))
        .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int primary = 0;
int secondary = 0;

//for (int i = 0, j = size - 1; i < size; i++, j--) //with more than one variable - not recommended
//{
//    primary += matrix[i, i];
//    secondary += matrix[j, i];
//}

for (int i = 0; i < size; i++)
{
    primary += matrix[i, i];
    secondary += matrix[size - i - 1, i];
}

Console.WriteLine(Math.Abs(primary - secondary));
