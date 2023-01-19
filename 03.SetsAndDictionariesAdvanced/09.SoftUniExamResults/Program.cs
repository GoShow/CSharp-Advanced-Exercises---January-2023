using System;
using System.Collections.Generic;
using System.Linq;

SortedDictionary<string, int> participantsPoints = new();
SortedDictionary<string, int> languagesSubmissions = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] tokens = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];

    if (tokens[1] == "banned")
    {
        participantsPoints.Remove(name);
        continue;
    }

    string language = tokens[1];
    int points = int.Parse(tokens[2]);

    if (!participantsPoints.ContainsKey(name))
    {
        participantsPoints.Add(name, 0);
    }

    if (participantsPoints[name] < points)
    {
        participantsPoints[name] = points;
    }

    if (!languagesSubmissions.ContainsKey(language))
    {
        languagesSubmissions.Add(language, 0);
    }

    languagesSubmissions[language]++;
}

Console.WriteLine("Results:");

foreach (var participantPoints in participantsPoints.OrderByDescending(p => p.Value))
{
    Console.WriteLine($"{participantPoints.Key} | {participantPoints.Value}");
}

Console.WriteLine("Submissions:");

foreach (var languageSubmissions in languagesSubmissions.OrderByDescending(l => l.Value))
{
    Console.WriteLine($"{languageSubmissions.Key} - {languageSubmissions.Value}");
}
