using System;
using System.Collections.Generic;
using System.Linq;

Queue<string> songs = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries));

while (songs.Any())
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = tokens[0];

    switch (command)
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Add":
            string song = string.Join(" ", tokens.Skip(1));
            if (songs.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
            }
            else
            {
                songs.Enqueue(song);
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songs));
            break;
    }
}

Console.WriteLine("No more songs!");
