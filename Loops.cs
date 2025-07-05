
using System;

public class Loops
{
    public static void loop1()
    {
        int[] nums = { 10, 20, 30, 40 };
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
        }
        Console.WriteLine(sum);
    }

    public static void loop2()
    {
        string[] cityNames = new string[] { "Lahore", "Karachi", "Hyderabad", "Larkana" };

        for (int i = cityNames.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(cityNames[i]);
        }

    }
    public static void loop3(){

        int i = 0;
        while(i<10){
           Console.WriteLine("True");
            i++;
        }
    }

}