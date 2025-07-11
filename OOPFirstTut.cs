using System;

public class ExampleOne
{
    public int StudentId;
    string Name;

    public void GetDetails()
    {
        Console.WriteLine("Enter ID of student:");
        StudentId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of student:");
        Name = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"\nThe name of the student is {Name} and their ID is {StudentId}");
    }
}

//public string Name { get; set; }  // Auto-implemented

public class ExampleTwo
{
    private int _studentId;
    private float _cgpa;   // studentId and cgpa are private variables. so we access them suing their public properties

    // Property for StudentId
    public int StudentId
    {
        get { return _studentId; }
        set
        {
            if (value > 0)
            {
                _studentId = value;
            }
            else
            {
                Console.WriteLine("\nInvalid ID");
            }
        }
    }

    // Property for CGPA
    public float CGPA
    {
        get { return _cgpa; }
        set
        {
            if (value >= 0.0 && value <= 4.0)
            {
                _cgpa = value;
            }
            else
            {
                Console.WriteLine("\nInvalid CGPA");
            }
        }
    }

    // Auto-implemented property for Name
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine($"ID: {StudentId}, Name: {Name}, CGPA: {CGPA}");
    }
}
