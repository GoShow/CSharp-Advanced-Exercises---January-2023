using CustomLinkedList;
using System;

CustomDoublyLinkedList<int> list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
list.AddLast(4);

Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());

int[] arr = list.ToArray();

list.ForEach(i => Console.WriteLine(i));

Console.WriteLine(list.Count);

CustomDoublyLinkedList<string> listString = new();

listString.AddFirst("some");
listString.AddFirst("random");
listString.AddFirst("strings");
listString.AddLast("added");

listString.ForEach(i => Console.WriteLine(i));

