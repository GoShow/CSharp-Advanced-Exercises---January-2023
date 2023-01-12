using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothes = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

int rack = int.Parse(Console.ReadLine());

int currentRack = rack;
int numberOfRacks = 1;

while (clothes.Any())
{
    currentRack -= clothes.Peek();

    if (currentRack < 0)
    {
        currentRack = rack;
        numberOfRacks++;

        continue;
    }

    clothes.Pop();
}

Console.WriteLine(numberOfRacks);

