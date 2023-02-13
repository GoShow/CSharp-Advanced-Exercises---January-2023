using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, int> peaks = new()
{
    { "Vihren", 80 },
    { "Kutelo", 90 },
    { "Banski Suhodol", 100 },
    { "Polezhan", 60 },
    { "Kamenitza", 70 }
};

Queue<string> peaksNames = new(new List<string> { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

List<string> conqueredPeaks = new() { };

Stack<int> foodPortions = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

Queue<int> staminaQuantities = new(
    Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

while (foodPortions.Any() && staminaQuantities.Any() && peaksNames.Any())
{
    int foodPortion = foodPortions.Pop();
    int staminaQuantity = staminaQuantities.Dequeue();
    int peakDifficulty = peaks[peaksNames.Peek()];

    if (foodPortion + staminaQuantity >= peakDifficulty)
    {
        conqueredPeaks.Add(peaksNames.Dequeue());
    }
}

if (peaksNames.Any())
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}

if (conqueredPeaks.Any())
{
    Console.WriteLine("Conquered peaks:");

    foreach (string peak in conqueredPeaks)
    {
        Console.WriteLine(peak);
    }
}