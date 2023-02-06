using BoxOfString;
using System;

Box<string> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

Console.WriteLine(box.ToString());
