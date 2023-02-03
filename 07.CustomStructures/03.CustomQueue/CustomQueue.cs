using System;

namespace CustomStructures;

public class CustomQueue
{
    private const int InitialCapacity = 4;
    private const int FirstElementIndex = 0;
    private int[] items;

    public CustomQueue()
    {
        items = new int[InitialCapacity];
    }
    public int Count { get; private set; }

    public void Enqueue(int item)
    {
        if (items.Length == Count)
        {
            Resize();
        }

        items[Count] = item;

        Count++;
    }

    public int Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The queue is empty");
        }

        int removedItem = items[FirstElementIndex];

        ShiftLeft(FirstElementIndex);

        // if needed Shrink

        Count--;

        return removedItem;
    }

    public int Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The queue is empty");
        }

        return items[FirstElementIndex];
    }

    public void Clear()
    {
        items = new int[InitialCapacity];

        Count = 0;
    }

    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < Count; i++)
        {
            int currentItem = items[i];

            action(currentItem);
        }
    }

    private void Resize()
    {
        int[] copy = new int[items.Length * 2];

        for (int i = 0; i < Count; i++)
        {
            copy[i] = items[i];
        }

        items = copy;
    }

    private void ShiftLeft(int index)
    {
        for (int i = index; i < Count; i++)
        {
            items[i] = items[i + 1];
        }
    }
}
