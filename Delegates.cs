using System;

// 1. Declare a delegate type
public delegate int CalculateDelegate(int num);

public class Delegates
{
    // 2. Static variable to track the result
    static int number = 10;

    // 3. Method matching the delegate signature
    public static int Addition(int value)
    {
        number += value;
        return number;
    }

    public static int Multiplication(int value)
    {
        number *= value;
        return number;
    }

    // 4. Method to get the current number
    public static int GetNumber()
    {
        return number;
    }
}







