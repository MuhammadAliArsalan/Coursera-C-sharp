using System;

public class Jumps
{
    public static void table()
    {
        Console.WriteLine("Enter table number: ");
        int tableNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the range: ");
        int range = int.Parse(Console.ReadLine());

        Console.Write('\n');

        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine($"{tableNo} * {i} = {tableNo * i}");

        }

    }

    public static void testBreak()
    {

        for (int i = 0; i < 10; i++)
        {
            if (i == 7)
                break;

            Console.WriteLine(i);
        }
    }

    public static void testContinue()
    {
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
                continue;    //skip even numbers
            Console.WriteLine("Odd no " + i);
        }
    }

    public static void RoleCheck()
    {
        Console.WriteLine("Enter user role (admin/user/guest): ");
        string role = Console.ReadLine().ToLower();

        switch (role)

        {
            case "admin":
                Console.WriteLine("Welcome Admin.");
                goto AllAccess;

            case "user":
                Console.WriteLine("Welcome User. You can view and edit your data.");
                break;

            case "guest":
                Console.WriteLine("Welcome Guest. You can only view data.");
                break;

            default:
                Console.WriteLine("Invalid role.");
                break;

            AllAccess:
                Console.WriteLine("You can modify all data.");
                break;
        }
    }



}