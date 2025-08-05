using System;

public delegate void PrintDelegate(string message);  // Step 1

public class AnonymousMethodExample
{
    public static void InvokeMethod()
    {
        // Step 2: Create anonymous method using delegate keyword

        PrintDelegate print = delegate (string msg)  //his is the anonymous method, i.e., unnamed function.
        {
            Console.WriteLine("Message from anonymous method: " + msg);
        };

        // Step 3: Call the delegate method
        print("Hello World!");  // Output: Message from anonymous method: Hello World!
    }
}