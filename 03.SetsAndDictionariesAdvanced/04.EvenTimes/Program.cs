using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<int, int> numbers = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);
    }

    numbers[number]++;
}

Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);
