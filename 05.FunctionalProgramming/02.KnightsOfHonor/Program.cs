using System;

Action<string[], string> printNamesWithAddedTitle = (names, title) =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle(names, "Sir");
