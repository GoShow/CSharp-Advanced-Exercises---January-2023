using System;
using System.Linq;

Func<string, int, bool> checkEqualOrLargerNameSum =
    (name, sum) => name.Sum(ch => ch) >= sum;
//(name, sum) =>
//{
//    int charsSum = name.Sum(ch => ch);

//    return charsSum >= sum;
//};


Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (names, sum, match) => names.FirstOrDefault(name => match(name, sum));
//(names, sum, match) =>
//{
//    foreach (var name in names)
//    {
//        if (match(name, sum))
//        {
//            return name;
//        }
//    }

//    return null;
//};
int sum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(getFirstName(names, sum, checkEqualOrLargerNameSum));
