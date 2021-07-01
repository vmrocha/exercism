using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    private static IDictionary<char, int> Values;

    static ScrabbleScore()
    {
        Values = new Dictionary<char, int>();
        "AEIOULNRST".ToList().ForEach(c => Values.Add(c, 1));
        "DG"        .ToList().ForEach(c => Values.Add(c, 2));
        "BCMP"      .ToList().ForEach(c => Values.Add(c, 3));
        "FHVWY"     .ToList().ForEach(c => Values.Add(c, 4));
        "K"         .ToList().ForEach(c => Values.Add(c, 5));
        "JX"        .ToList().ForEach(c => Values.Add(c, 8));
        "QZ"        .ToList().ForEach(c => Values.Add(c, 10));
    }

    public static int Score(string input)
    {
        return input.ToUpper().Select(c => Values[c]).Sum();
    }
}