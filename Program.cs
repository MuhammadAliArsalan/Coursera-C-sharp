// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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

        //Create object of ExampleThree
        //ExampleThree student = new ExampleThree();
        //student.StudentName = "Ahmed";
        //student.DisplayInfo();


        //ExampleFour student2 = new ExampleFour("Ali", 3.09f, 12);  //parameterized constructor
        //student2.DisplayInfo();

        //Student s5 = new Student();
        //s5.DisplayInfo(23);


        //Example of constructor overlaoding

        //Console.WriteLine("\n");
        //Student s1 = new Student();
        //s1.DisplayInfo();

        //// Using constructor with 1 parameter
        //Student s2 = new Student(101);
        //s2.DisplayInfo();

        //// Using constructor with 2 parameters
        //Student s3 = new Student(102, "Ali Arslan");
        //s3.DisplayInfo();


        //OOP tut3.cs

        //Car myCar = new Car("LC-300", 35000000, "Muhammad Ali");

        //// Call base class method
        //myCar.AcceptDetails();
        //myCar.DisplayDetails();

        //// Call derived class method
        //myCar.ShowDetails();


        //// OOPTut4.cs
        //// Department object
        //Department dep = new Department();
        //dep.AcceptFacultyDetails();
        //dep.AcceptDepartmentDetails();
        //dep.Teach();              // From Faculty
        //dep.ManageDepartment();   // From Department

        //// Student object
        //MyStudent stu = new MyStudent();
        //stu.AcceptFacultyDetails();
        //stu.AcceptStudentDetails();
        //stu.Study();

        //PolymorphTut.cs
        Person p1 = new Person();
        p1.PayBill();
        p1.PayBill(20);
        p1.PayBill(7000, "High Income");

        Parent P1 = new Parent();
        Parent P2 = new Parent("Ali Arslan");
        Parent P3 = new Parent("hamza Khan", 34);

        Consumer standard = new Consumer();
        Consumer low = new LowerInc();
        Consumer high = new HighInc();


        standard.PayBill(120);   // Standard user
        low.PayBill(120);        // Lower income user
        high.PayBill(120);

        //Abstract Tut.cs


        // Ywe can't do this:
        // BankAccount acc = new BankAccount();  (Compiler Error;can not be insatantiated)

        // But ywe can do this:
        BankAccount acc = new SavingAccount(); 

        acc.Deposit();    // Output: Amount deposited...
        acc.Withdraw();   // Output: Amount withdrawn...
        acc.Balance();    // Output: Balance in saving account
        acc.GetMessage(); // Output: Welcome to ABC Bank.

    }
}
