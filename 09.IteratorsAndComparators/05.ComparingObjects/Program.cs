using ComparingObjects;
using System;
using System.Collections.Generic;

List<Person> people = new();

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] personProps = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new()
    {
        Name = personProps[0],
        Age = int.Parse(personProps[1]),
        Town = personProps[2]
    };

    people.Add(person);
}

int compareIndex = int.Parse(Console.ReadLine()) - 1;

Person personToCompare = people[compareIndex];

int equalCount = 0;
int diffCount = 0;

foreach (var person in people)
{
    if (person.CompareTo(personToCompare) == 0)
    {
        equalCount++;
    }
    else
    {
        diffCount++;
    }
}

if (equalCount == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
}
