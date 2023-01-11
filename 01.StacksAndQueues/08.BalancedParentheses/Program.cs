using System;
using System.Collections.Generic;
using System.Linq;

string parentheses = Console.ReadLine();

Stack<char> stack = new();

foreach (var parenthese in parentheses)
{
    switch (parenthese)
    {
        case '{':
        case '(':
        case '[':
            stack.Push(parenthese);
            break;
        case '}':
            if (!stack.Any() || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ')':
            if (!stack.Any() || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (!stack.Any() || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
    }
}

Console.WriteLine("YES");