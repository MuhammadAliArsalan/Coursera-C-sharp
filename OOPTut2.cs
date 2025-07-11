using System;

public class ExampleThree
{
    private int StudentID;
    public string StudentName;

    public ExampleThree()
    {
        StudentID = 1;
        StudentName = "Muhammad Ali Arslan";
    }
    public void DisplayInfo()
    {
        Console.WriteLine("StudentID " + StudentID);
        Console.WriteLine("Student's Name " + StudentName);

    }

}
public class ExampleFour
{
    private string StudentName;
    public float CGPA = 3.9f;
    private int StudentID;

    public ExampleFour(string name, float cgpa, int Sid)
    {
        StudentName = name;
        CGPA=cgpa;
        StudentID = Sid;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("The name of student is " + StudentName + " his CGPA is " + CGPA + " and his ID is " + StudentID);

    }

}

public class Student
{
    private int studentId;
    private string studentName;

    // Constructor 1: Default constructor (no parameters)
    public Student()
    {
        studentId = 0;
        studentName = "Unknown";
    }

    //  Constructor 2: Parameterized constructor (int only)
    public Student(int id)
    {
        studentId = id;
        studentName = "Not Provided";
    }

    //  Constructor 3: Parameterized constructor (int and string)
    public Student(int id, string name)
    {
        studentId = id;
        studentName = name;
    }


    public void DisplayInfo()
    {
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("-------------------------");
    }
}