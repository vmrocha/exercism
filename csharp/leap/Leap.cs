using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return (year % 100 == 0 && year % 400 != 0) ? false : year % 4 == 0;
    }
}