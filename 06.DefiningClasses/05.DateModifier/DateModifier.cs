using System;

namespace Date_Modifier;

public static class DateModifier
{
    public static int GetDifferenceInDays(string start, string end)
    {
        DateTime startDate = DateTime.Parse(start);
        DateTime endDate = DateTime.Parse(end);

        TimeSpan difference = endDate - startDate;

        return Math.Abs(difference.Days);
    }
}
