using System;
using System.Collections.Generic;

SortedDictionary<char, int> chars = new();

string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];

    if (!chars.ContainsKey(ch))
    {
        chars.Add(ch, 0);
    }

    chars[ch]++;
}

foreach (var ch in chars)
{
    Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
}

