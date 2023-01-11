using System;
using System.Collections.Generic;
using System.Linq;

string[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int elementsToDequeue = int.Parse(tokens[1]);

int number = int.Parse(tokens[2]);

Queue<int> queue = new(numbers);

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
