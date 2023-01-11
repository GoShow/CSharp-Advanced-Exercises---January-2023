using System;
using System.Collections.Generic;

string text = string.Empty;
Stack<string> changes = new();

int operationsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < operationsCount; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int command = int.Parse(tokens[0]);

    switch (command)
    {
        case 1:
            changes.Push(text);
            text += tokens[1];
            break;
        case 2:
            changes.Push(text);
            int count = int.Parse(tokens[1]);
            text = text.Remove(text.Length - count);
            break;
        case 3:
            int index = int.Parse(tokens[1]) - 1;
            Console.WriteLine(text[index]);
            break;
        case 4:
            text = changes.Pop();
            break;
    }
}

