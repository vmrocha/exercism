using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random R = new Random();
    private static readonly HashSet<string> Assigned = new HashSet<string>();

    public Robot()
    {
        Reset();
    }

    public string Name { get; private set; }

    public void Reset()
    {
        Name = GenerateUniqueName();
    }

    private static string GenerateRandomName()
    {
        var letter1 = (char)R.Next(65, 91);
        var letter2 = (char)R.Next(65, 91);
        return $"{letter1}{letter2}{R.Next(1000):000}";
    }

    private static string GenerateUniqueName()
    {
        string name;

        do name = GenerateRandomName();
        while(Assigned.Contains(name));
        Assigned.Add(name);

        return name;
    }
}