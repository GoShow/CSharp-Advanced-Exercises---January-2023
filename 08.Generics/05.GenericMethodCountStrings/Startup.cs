using GenericMethodCountStrings;
using System;

Box<string> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

string itemToCompare = Console.ReadLine();

Console.WriteLine(box.Count(itemToCompare));
