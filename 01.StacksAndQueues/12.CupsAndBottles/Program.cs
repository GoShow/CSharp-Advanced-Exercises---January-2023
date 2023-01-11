using System;
using System.Collections.Generic;
using System.Linq;

Queue<int> cups = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray());

Stack<int> bottles = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray());

int wastedWater = 0;

while (cups.Any() && bottles.Any())
{
    int cup = cups.Dequeue();
    int bottle = bottles.Pop();

    cup -= bottle;

    if (cup <= 0)
    {
        wastedWater += Math.Abs(cup);
        continue;
    }

    while (cup > 0 && bottles.Any())
    {
        bottle = bottles.Pop();
        cup -= bottle;

        if (cup <= 0)
        {
            wastedWater += Math.Abs(cup);
            break;
        }
    }
}

if (cups.Any())
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}

Console.WriteLine($"Wasted litters of water: {wastedWater}");