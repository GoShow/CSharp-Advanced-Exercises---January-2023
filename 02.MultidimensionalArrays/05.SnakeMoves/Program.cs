using System;
using System.Linq;

int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string word = Console.ReadLine();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];

int currentWordIndex = 0;

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            if (currentWordIndex == word.Length)
            {
                currentWordIndex = 0;
            }

            matrix[row, col] = word[currentWordIndex];

            currentWordIndex++;
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            if (currentWordIndex == word.Length)
            {
                currentWordIndex = 0;
            }

            matrix[row, col] = word[currentWordIndex];

            currentWordIndex++;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write($"{matrix[row, col]}");
    }

    Console.WriteLine();
}