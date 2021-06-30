using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = new HashSet<char>();
        foreach (var c in word.ToLower())
            if (char.IsLetter(c) && !letters.Add(c))
                return false;

        return true;
    }
}
