using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var splitChars = new char[] {' ', '-', '_' };
        var splitOptions = StringSplitOptions.RemoveEmptyEntries;
        return new string(phrase.ToUpper()
                                .Split(splitChars, splitOptions)
                                .Select(x => x[0])
                                .ToArray());
    }
}