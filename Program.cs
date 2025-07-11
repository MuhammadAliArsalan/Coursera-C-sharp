// See https://aka.ms/new-console-template for more information
using System;


public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("Let's start learning C#");

        //int myAge = 23;
        //float CGPA = 3.156f; 
        //string myName = "M.Ali"; 

        //Console.WriteLine("My age is " + myAge + ", my name is " + myName + ", and my CGPA is " + CGPA);

        ////Operators.cs

        //Operators.CalculateNetSalary();
        //Operators.CalTemp();
        //Operators.Verified();

        //////Conditionals.cs

        //Conditionals.canVote();
        //Conditionals.isAllowed();

        //////Loops.cs

        //Loops.loop1();
        //Loops.loop2();
        //Loops.loop3();

        //////jumps.cs

        //Jumps.table();
        //Jumps.testBreak();
        //Jumps.testContinue();
        //Jumps.RoleCheck();

        ////Array_Prac.cs
        //Array_Prac1.array1();
        //Array_Prac1.MultiArray();
        //Array_Prac1.JaggedArray();

        ////Strings.cs

        //StringTut.String1();

        //OOPFirst Tut
        //ExampleOne s1 = new ExampleOne();
        //s1.GetDetails();
        //s1.Display();
        //int id = s1.StudentId;   // since ID is public it can be accessed outside of class
        //Console.WriteLine(id);


        //ExampleTwo s2 = new ExampleTwo();
        //s2.StudentId = 23;
        //s2.Name = "Umer";
        //s2.CGPA = 3.90f;
        //s2.Display();

        //OOP First Tut2

        Create object of ExampleThree
        ExampleThree student = new ExampleThree();
        student.StudentName = "Ahmed";
        student.DisplayInfo();


        ExampleFour student2 = new ExampleFour("Ali", 3.09f, 12);  //parameterized constructor
        student2.DisplayInfo();

        Student s5 = new Student();
        s5.DisplayInfo(23);


        //Example of constructor overlaoding

        Console.WriteLine("\n");
        Student s1 = new Student();
        s1.DisplayInfo();

        // Using constructor with 1 parameter
        Student s2 = new Student(101);
        s2.DisplayInfo();

        // Using constructor with 2 parameters
        Student s3 = new Student(102, "Ali Arslan");
        s3.DisplayInfo();




    }
}
