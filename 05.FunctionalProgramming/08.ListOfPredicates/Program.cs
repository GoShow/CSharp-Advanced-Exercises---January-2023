using System;
using System.Collections.Generic;
using System.Linq;

List<Predicate<int>> predicates = new();

int endRange = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

int[] numbers = Enumerable.Range(1, endRange).ToArray();

foreach (var divider in dividers)
{
    predicates.Add(p => p % divider == 0);
}

foreach (var number in numbers)
{
    bool isDivisible = true; // predicates.All(match => match(number));

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}
