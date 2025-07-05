using System;

public class Operators
{
    public static void CalculateNetSalary()
    {
        float baseSalary = 50000;
        float HRA = 0.30F;

        float netSalary = baseSalary - (baseSalary * HRA);
        Console.WriteLine("The base Salary is " + baseSalary);
        Console.WriteLine("The net salary is " + netSalary);
    }

    public static void CalTemp()
    {
        float celsius = 50;
        float fahrenheit = (1.8f * celsius) + 32;


        Console.WriteLine("The temp in fahrehneit is "+ fahrenheit);

        if (fahrenheit > 100)
        {
            Console.WriteLine("It is hot outside");
        }
        else
        {
            Console.WriteLine("It is moderate");
        }

    }

    public static void Verified()
    {
        bool isReg = true;
        bool isLoggedIn = true;
        if (isReg && isLoggedIn)
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access granted");


        }
    }
}
