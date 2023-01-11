using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothes = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

int capacity = int.Parse(Console.ReadLine());

int currentCapacity = capacity;
int numberOfRacks = 1;

while (clothes.Any())
{
    currentCapacity -= clothes.Peek();

    if (currentCapacity < 0)
    {
        currentCapacity = capacity;
        numberOfRacks++;

        continue;
    }

    clothes.Pop();
}

Console.WriteLine(numberOfRacks);

