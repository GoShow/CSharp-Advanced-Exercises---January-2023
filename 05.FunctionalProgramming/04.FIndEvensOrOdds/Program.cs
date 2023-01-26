using System;
using System.Collections.Generic;
using System.Linq;

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

bool isEven = Console.ReadLine() == "even";

Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

List<int> numbers = generateRange(range[0], range[1]);

Predicate<int> match;

if (isEven)
{
    match = number => number % 2 == 0;
}
else
{
    match = number => number % 2 != 0;
}

List<int> result = new();

foreach (var number in numbers)
{
    if (match(number))
    {
        result.Add(number);
    }
}

Console.WriteLine(string.Join(" ", result));

