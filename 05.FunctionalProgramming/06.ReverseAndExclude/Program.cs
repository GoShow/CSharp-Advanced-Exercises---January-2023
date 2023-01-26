using System;
using System.Collections.Generic;
using System.Linq;

Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};

Func<List<int>, Predicate<int>, List<int>> excludeDivisible = (numbers, match) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        if (!match(number))
        {
            result.Add(number);
        }
    }

    return result;
};

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int divider = int.Parse(Console.ReadLine());

numbers = excludeDivisible(numbers, n => n % divider == 0);
numbers = reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));

