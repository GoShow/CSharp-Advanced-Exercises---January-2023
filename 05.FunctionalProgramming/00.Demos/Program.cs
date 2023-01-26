using System;

Action<string> printName = (name) => Console.WriteLine(name);
//Action<string> printName = PrintName;

static void PrintName(string name)
{
    Console.WriteLine(name);
}

printName("Steven Gerrard");
PrintName("Jurgen Klopp");

Func<int, int, int> sumNumbers = (num1, num2) => num1 + num2;
//Func<int, int, int> sumNumbers = SumNumbers;

static int SumNumbers(int num1, int num2)
{
    return num1 + num2;
}

Console.WriteLine(sumNumbers(5, 5));
Console.WriteLine(SumNumbers(1, 5));

Predicate<int> isEven = number => number % 2 == 0;
//Predicate<int> isEven = IsEven;
//Filter filter = number => number % 2 == 0;

static bool IsEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine(isEven(4));
Console.WriteLine(IsEven(4));

delegate bool Filter(int number);
