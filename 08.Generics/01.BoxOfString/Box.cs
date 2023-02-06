using System.Collections.Generic;
using System.Text;

namespace BoxOfString;

public class Box<T>
{
    private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
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
}
