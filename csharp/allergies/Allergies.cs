using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly Allergen[] _allValues;

    public Allergies(int mask)
    {
        _allValues = BreakDown((Allergen)mask);
    }

    public bool IsAllergicTo(Allergen allergen)
        => Array.Exists(_allValues, v => v == allergen);

    public Allergen[] List() => _allValues;

    private static Allergen[] BreakDown(Allergen mask)
    {
        var result = new List<Allergen>();

        foreach (Allergen value in Enum.GetValues(typeof(Allergen)))
            if (mask.HasFlag(value))
                result.Add(value);

        return result.ToArray();
    }
}