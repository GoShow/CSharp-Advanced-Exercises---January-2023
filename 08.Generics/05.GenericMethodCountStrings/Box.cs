using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMethodCountStrings;

public class Box<T> where T : IComparable<T>
{
    private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        foreach (var item in items)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        T temp = items[firstIndex];
        items[firstIndex] = items[secondIndex];
        items[secondIndex] = temp;
    }

    public int Count(T itemToCompare)
    {
        int count = 0;

        foreach (var item in items)
        {
            if (item.CompareTo(itemToCompare) > 0)
            {
                count++;
            }
        }

        return count;
    }
}

