using BoxOfInteger;
using System;

Box<int> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int item = int.Parse(Console.ReadLine());

    box.Add(item);
}

Console.WriteLine(box.ToString());
