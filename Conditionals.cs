public class Conditionals
{
    public static void canVote()
    {
        Console.WriteLine("\nEnter age of person: ");
        int age = int.Parse(Console.ReadLine());
        if (age < 18)
        {
            Console.WriteLine("You can not vote");
        }
        else if (age > 18 && age < 60)
        {
            Console.WriteLine("You can vote easily");

        }
        else
        {
            Console.WriteLine("You can NOT vote");

        }
    }

    public static void isAllowed()
    {
        Console.WriteLine("Enter user type");
        string userType = Console.ReadLine();

        switch (userType)
        {
            case "Admin":
                Console.WriteLine("You have full access");
                break;

            case "subAdmin":
                Console.WriteLine("You have access to user accounts only");
                break;

            case "user":
            case "User":
                Console.WriteLine("You have access to your personal account only");
                break;

            default:
                Console.WriteLine("Wrong entry");
                break;
        }
    }

}