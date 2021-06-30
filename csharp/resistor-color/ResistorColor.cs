using System;

public static class ResistorColor
{
    private static string[] ColorValues = new []
    {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };
    public static int ColorCode(string color)
    {
        return Array.IndexOf(ColorValues, color);
    }

    public static string[] Colors()
    {
        return ColorValues;
    }
}