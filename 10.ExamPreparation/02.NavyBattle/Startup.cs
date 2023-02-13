using System;

int size = int.Parse(Console.ReadLine());

char[,] battlefield = new char[size, size];

int submarineRow = 0;
int submarineCol = 0;

for (int row = 0; row < size; row++)
{
    string rowInput = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        battlefield[row, col] = rowInput[col];

        if (battlefield[row, col] == 'S')
        {
            submarineRow = row;
            submarineCol = col;
        }
    }
}

int hitsTaken = 0;
int enemyCruisersCount = 3;

while (true)
{
    battlefield[submarineRow, submarineCol] = '-';

    string command = Console.ReadLine();

    switch (command)
    {
        case "up": submarineRow--; break;
        case "down": submarineRow++; break;
        case "left": submarineCol--; break;
        case "right": submarineCol++; break;
    }

    if (battlefield[submarineRow, submarineCol] == 'C')
    {
        enemyCruisersCount--;
    }
    else if (battlefield[submarineRow, submarineCol] == '*')
    {
        hitsTaken++;
    }

    if (hitsTaken == 3)
    {
        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
        break;
    }

    if (enemyCruisersCount == 0)
    {
        Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
        break;
    }
}

battlefield[submarineRow, submarineCol] = 'S';

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(battlefield[row, col]);
    }

    Console.WriteLine();
}
