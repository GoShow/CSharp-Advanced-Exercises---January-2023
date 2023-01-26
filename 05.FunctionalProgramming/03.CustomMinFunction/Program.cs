using System;
using System.Linq;

Func<int[], int> min = (numbers) =>
{
    int min = int.MaxValue;

    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
};

int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine(min(numbers));