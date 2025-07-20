using System;

public static class IntExtensions
{
    public static bool IsGreaterThan(this int number, int value) 
    { 
        return number>value;
    }
    public static bool IsSmallerThan(this int number,int value) {
        return number < value;
     }
}