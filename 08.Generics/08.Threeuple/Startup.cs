using System;
using ThreeupleType;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] bankTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Threeuple<string, string, string> person =
    new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

Threeuple<string, int, bool> drinks =
    new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

Threeuple<string, double, string> bank =
    new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

Console.WriteLine(person);
Console.WriteLine(drinks);
Console.WriteLine(bank);