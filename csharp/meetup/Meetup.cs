using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int _month;
    private readonly int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDay = schedule == Schedule.Teenth ? 13 : 1;
        var date = new DateTime(_year, _month, firstDay);
        
        while (date.DayOfWeek != dayOfWeek)
        {
            date = date.AddDays(1);
        }
        
        if (schedule >= Schedule.Second &&
            schedule <= Schedule.Fourth)
        {
            date = date.AddDays(7 * ((int)schedule - 1));
        }

        if (schedule == Schedule.Last)
        {
            var days = DateTime.DaysInMonth(_year, _month);
            while (date.Day <= days - 7)
                date = date.AddDays(7);
        }
        
        return date;
    }
}