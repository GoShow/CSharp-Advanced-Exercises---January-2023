using System;

namespace CustomLinkedList;

public class CustomDoublyLinkedList<T>
{
    private class ListNode
    {
        public ListNode(T value)
        {
            Value = value;
        }

        public ListNode NextNode { get; set; }

        public ListNode PreviousNode { get; set; }

        public T Value { get; set; }
    }

    private ListNode head;
    private ListNode tail;

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        ListNode newHead = new(element);

        if (Count == 0)
        {
            head = tail = newHead;
        }
        else
        {
            newHead.NextNode = head;
            head.PreviousNode = newHead;
            head = newHead;
        }

        Count++;
    }

    public void AddLast(T element)
    {
        ListNode newTail = new(element);

        if (Count == 0)
        {
            tail = head = newTail;
        }
        else
        {
            newTail.PreviousNode = tail;
            tail.NextNode = newTail;
            tail = newTail;
        }

        Count++;
    }

    public T RemoveFirst()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T removedElement = head.Value;

        ListNode newHead = head.NextNode;

        if (Count == 1)
        {
            head = tail = null;
        }
        else
        {
            newHead.PreviousNode = null;
            head = newHead;
        }

        Count--;

        return removedElement;
    }

    public T RemoveLast()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The list is empty");
        }

        T removedElement = tail.Value;

        ListNode newTail = tail.PreviousNode;

        if (Count == 1)
        {
            tail = head = null;
        }
        else
        {
            newTail.NextNode = null;
            tail = newTail;
        }

        Count--;

        return removedElement;
    }

    public void ForEach(Action<T> action)
    {
        ListNode currentNode = head;

        while (currentNode != null)
        {
            action(currentNode.Value);
            currentNode = currentNode.NextNode;
        }
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];

        var currentNode = head;

        for (int i = 0; i < Count; i++)
        {
            array[i] = currentNode.Value;
            currentNode = currentNode.NextNode;
        }

        return array;
    }
}
