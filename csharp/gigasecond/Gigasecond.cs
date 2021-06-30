using System;

public static class Gigasecond
{
    private static double TotalSeconds = Math.Pow(10, 9);
    public static DateTime Add(DateTime moment)
    {
        return moment.Add(TimeSpan.FromSeconds(TotalSeconds));
    }
}