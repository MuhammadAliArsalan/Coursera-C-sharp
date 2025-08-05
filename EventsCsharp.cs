using System;

public class EventsExample
{
    // Step 1: Declare the delegate type
    public delegate void delegate_OddNumber();

    //declare event using the delegat
    public event delegate_OddNumber event_OddNumber;

    public void addition()
    {
        int num1 = 100;
        int num2 = 203;
        int result = num1 + num2;
        Console.WriteLine(result);

        // Step 4: Raise event if result is an odd number
        if (result % 2 != 0 && event_OddNumber != null)
        {
            event_OddNumber(); // Raise the event
        }
    }
}