using System;
using System.Collections.Generic;
using System.Linq;

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value)); //p => p.StartWith("P")
    }
    else
    {
        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

        foreach (var person in peopleToDouble)
        {
            int index = people.FindIndex(p => p == person);

            people.Insert(index, person);
        }
    }
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;
    }
}
