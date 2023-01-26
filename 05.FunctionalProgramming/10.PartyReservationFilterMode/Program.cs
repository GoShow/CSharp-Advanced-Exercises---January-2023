using System;
using System.Collections.Generic;
using System.Linq;

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, Predicate<string>> filters = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Print")
{
    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Add filter")
    {
        filters.Add(filter + value, GetPredicate(filter, value));
    }
    else
    {
        filters.Remove(filter + value);
    }
}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", people));

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Contains":
            return p => p.Contains(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}
