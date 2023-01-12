using System;
using System.Collections.Generic;
using System.Linq;

int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int elementsToPush = tokens[0];
int elementsToPop = tokens[1];
int number = tokens[2];

Stack<int> stack = new();

for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(numbers[i]);
}

for (int i = 0; i < elementsToPop; i++)
{
    stack.Pop();
}

if (stack.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
