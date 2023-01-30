using System;

namespace DefiningClasses;

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

        Person noNameDefaultAge = new();
        Person noNameWithAge = new(25);
        Person john = new("John", 32);

        Console.WriteLine($"{peter.Name} is {peter.Age} years old");
        Console.WriteLine($"{george.Name} is {george.Age} years old");

        Console.WriteLine($"{noNameDefaultAge.Name} is {noNameDefaultAge.Age} years old");
        Console.WriteLine($"{noNameWithAge.Name} is {noNameWithAge.Age} years old");
        Console.WriteLine($"{john.Name} is {john.Age} years old");
    }
}