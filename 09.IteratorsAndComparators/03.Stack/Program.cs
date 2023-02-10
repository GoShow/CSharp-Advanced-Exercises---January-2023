using Stack;
using System;
using System.Linq;


CustomStack<int> stack = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command
        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];

    if (action == "Push")
    {
        int[] itemsToPush = tokens
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        foreach (var item in itemsToPush)
        {
            stack.Push(item);
        }
    }
    else
    {
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

foreach (var item in stack)
{
    Console.WriteLine(item);
}

foreach (var item in stack)
{
    Console.WriteLine(item);
}

