using System;
using System.Collections.Generic;

Dictionary<string, Dictionary<string, int>> clothesByColor = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor[color] = new Dictionary<string, int>();
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentClothing = tokens[j];

        if (!clothesByColor[color].ContainsKey(currentClothing))
        {
            clothesByColor[color].Add(currentClothing, 0);
        }

        clothesByColor[color][currentClothing]++;
    }
}

string[] findParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var color in clothesByColor)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var cloth in color.Value)
    {
        string printItem = $"* {cloth.Key} - {cloth.Value}";

        if (color.Key == findParams[0] && cloth.Key == findParams[1])
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}
