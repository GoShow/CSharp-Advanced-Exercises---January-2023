using GenericMethodSwapIntegers;
using System;
using System.Linq;

Box<int> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int item = int.Parse(Console.ReadLine());

    box.Add(item);
}

int[] indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(indices[0], indices[1]);

Console.WriteLine(box.ToString());
