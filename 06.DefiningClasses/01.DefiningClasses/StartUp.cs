using DefiningClasses;
using System;

public class StartUp
{
    static void Main(string[] args)
    {
        Person peter = new();
        peter.Name = "Peter";
        peter.Age = 20;

        Person george = new()
        {
            Name = "George",
            Age = 18
        };

        Console.WriteLine($"{peter.Name} is {peter.Age} years old");
        Console.WriteLine($"{george.Name} is {george.Age} years old");
    }
}