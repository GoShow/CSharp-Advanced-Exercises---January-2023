using System;
using System.Linq;

int size = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

char[,] matrix = new char[size, size];

int startRow = 0;
int startCol = 0;
int coalsCount = 0;

for (int row = 0; row < size; row++)
{
    char[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => char.Parse(n)).ToArray();

    for (int col = 0; col < size; col++)
    {
        if (chars[col] == 's')
        {
            startRow = row;
            startCol = col;
        }
        else if (chars[col] == 'c')
        {
            coalsCount++;
        }

        matrix[row, col] = chars[col];
    }
}

int currentRow = startRow;
int currentCol = startCol;

foreach (string command in commands)
{
    bool isEnd = false;
    switch (command)
    {
        case "up":
            if (currentRow > 0)
            {
                currentRow--;
                isEnd = ProcessCell(currentRow, currentCol);
            }
            break;
        case "left":
            if (currentCol > 0)
            {
                currentCol--;
                isEnd = ProcessCell(currentRow, currentCol);
            }
            break;
        case "right":
            if (currentCol < size - 1)
            {
                currentCol++;
                isEnd = ProcessCell(currentRow, currentCol);
            }
            break;
        case "down":
            if (currentRow < size - 1)
            {
                currentRow++;
                isEnd = ProcessCell(currentRow, currentCol);
            }
            break;
    }

    if (isEnd)
    {
        break;
    }
}

if (matrix[currentRow, currentCol] == 'e')
{
    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

    return;
}

if (coalsCount == 0)
{
    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

    return;
}

Console.WriteLine($"{coalsCount} coals left. ({currentRow}, {currentCol})");

bool ProcessCell(int row, int col)
{
    switch (matrix[row, col])
    {
        case 'e':
            return true;
        case 'c':
            matrix[row, col] = '*';
            coalsCount--;
            if (coalsCount == 0)
            {
                return true;
            }

            return false;
        default:
            return false;
    }
}