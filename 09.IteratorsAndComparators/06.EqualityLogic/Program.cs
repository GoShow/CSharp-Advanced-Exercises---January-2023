using EqualityLogic;
using System;
using System.Collections.Generic;


HashSet<Person> hashSet = new();
SortedSet<Person> sortedSet = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] personProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new()
    {
        Name = personProps[0],
        Age = int.Parse(personProps[1])
    };

    hashSet.Add(person);
    sortedSet.Add(person);
}

Console.WriteLine(hashSet.Count);
Console.WriteLine(sortedSet.Count);
