using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines;

public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder sb = new();

        using StreamReader streamReader = new(inputFilePath);

        string line = string.Empty;

        int count = 0;

        while (line != null)
        {
            line = streamReader.ReadLine();

            if (count % 2 == 0)
            {
                string replacedSymbols = ReplaceSymbols(line);
                string reversedWords = ReverseWords(replacedSymbols);
                sb.AppendLine(reversedWords);
            }

            count++;
        }

        return sb.ToString().TrimEnd();
    }

    private static string ReplaceSymbols(string line)
    {
        StringBuilder sb = new(line);

        string[] symbolsToReplace = { "-", ",", ".", "!", "?" };

        foreach (var symbol in symbolsToReplace)
        {
            sb = sb.Replace(symbol, "@");
        }

        return sb.ToString();
    }

    private static string ReverseWords(string replacedSymbols)
    {
        string[] reversedWords = replacedSymbols
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToArray();

        return string.Join(" ", reversedWords);
    }
}
