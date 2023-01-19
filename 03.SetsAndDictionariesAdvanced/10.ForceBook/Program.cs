using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string, SortedSet<string>> sidesUsers = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    if (command.Contains('|'))
    {
        string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        string side = tokens[0];
        string user = tokens[1];

        if (!sidesUsers.Values.Any(u => u.Contains(user)))
        {
            if (!sidesUsers.ContainsKey(side))
            {
                sidesUsers.Add(side, new SortedSet<string>());
            }

            sidesUsers[side].Add(user);
        }
    }
    else
    {
        string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        string side = tokens[1];
        string user = tokens[0];

        foreach (var sideUsers in sidesUsers)
        {
            if (sideUsers.Value.Contains(user))
            {
                sideUsers.Value.Remove(user);
                break;
            }
        }

        if (!sidesUsers.ContainsKey(side))
        {
            sidesUsers.Add(side, new SortedSet<string>());
        }

        sidesUsers[side].Add(user);

        Console.WriteLine($"{user} joins the {side} side!");
    }
}

Dictionary<string, SortedSet<string>> orderedSidesUsers = sidesUsers
    .OrderByDescending(s => s.Value.Count)
    .ToDictionary(s => s.Key, s => s.Value);

foreach (var sideUsers in orderedSidesUsers)
{
    if (sideUsers.Value.Count > 0)
    {
        Console.WriteLine($"Side: {sideUsers.Key}, Members: {sideUsers.Value.Count}");

        foreach (var user in sideUsers.Value)
        {
            Console.WriteLine($"! {user}");
        }
    }
}