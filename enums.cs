using EnumExmaple;
using System;

namespace EnumExmaple
{
    enum Weekdays
    {
        Monday=10,
        Tuesday=34,
        Wednesday=44,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}
public class EnumDemo
{
    public void DisplayDays()
    {
        Console.WriteLine(Weekdays.Monday);
        int day=(int)Weekdays.Monday;
        Console.WriteLine(" Monday lies at position " + day);
        Console.WriteLine(Weekdays.Tuesday);
        int day2=(int)Weekdays.Tuesday;
        Console.WriteLine("tuesday lies at position "+day2);
        Console.Write(Weekdays.Wednesday);
        Console.WriteLine("\nWednesday lies at position " + (int)Weekdays.Wednesday);
    }
}