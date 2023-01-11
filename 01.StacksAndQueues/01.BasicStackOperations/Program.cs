using System;
using System.Collections.Generic;
using System.Linq;

string[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int elementsToPush = int.Parse(tokens[0]);
int elementsToPop = int.Parse(tokens[1]);
int number = int.Parse(tokens[2]);

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
