using System;
using System.Linq;

int[] dimenions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimenions[0];
int cols = dimenions[1];

char[,] matrix = new char[rows, cols];

int playerRow = 0;
int playerCol = 0;

for (int row = 0; row < rows; row++)
{
    string rowData = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];

        if (rowData[col] == 'P')
        {
            playerRow = row;
            playerCol = col;
            matrix[playerRow, playerCol] = '.';
        }
    }
}

string directions = Console.ReadLine();

foreach (var direction in directions)
{
    int oldPlayerRow = playerRow;
    int oldPlayerCol = playerCol;

    switch (direction)
    {
        case 'L':
            playerCol--;
            break;
        case 'R':
            playerCol++;
            break;
        case 'U':
            playerRow--;
            break;
        case 'D':
            playerRow++;
            break;
    }

    matrix = SpreadBunnies();

    if (playerRow < 0
        || playerRow >= rows
        || playerCol < 0
        || playerCol >= cols)
    {
        PrintResult(oldPlayerRow, oldPlayerCol, "won");
        break;
    }

    if (matrix[playerRow, playerCol] == 'B')
    {
        PrintResult(playerRow, playerCol, "dead");
        break;
    }
}

char[,] SpreadBunnies()
{
    char[,] newMatrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            newMatrix[row, col] = matrix[row, col];
        }
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row, col] == 'B')
            {
                if (row > 0) //up
                {
                    newMatrix[row - 1, col] = 'B';
                }
                if (row < rows - 1) //down
                {
                    newMatrix[row + 1, col] = 'B';
                }
                if (col > 0) //left
                {
                    newMatrix[row, col - 1] = 'B';
                }
                if (col < cols - 1) //right
                {
                    newMatrix[row, col + 1] = 'B';
                }
            }
        }
    }

    return newMatrix;
}

void PrintResult(int playerRow, int playerCol, string result)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }

    Console.WriteLine($"{result}: {playerRow} {playerCol}");
}