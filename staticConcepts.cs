using System;

static class Calculate
{
    static int count = 0;

    static Calculate()
    {
        count = 0;
    }

    public static int Increment()
    {
        return ++count;  // increment and return
    }

    public static int Decrement()
    {
        return --count;  // decrement and return
    }

    public static int GetCount()
    {
        return count;
    }
}


