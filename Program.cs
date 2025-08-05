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
        //Person p1 = new Person();
        //p1.PayBill();
        //p1.PayBill(20);
        //p1.PayBill(7000, "High Income");

        //Parent P1 = new Parent();
        //Parent P2 = new Parent("Ali Arslan");
        //Parent P3 = new Parent("hamza Khan", 34);

        //Consumer standard = new Consumer();
        //Consumer low = new LowerInc();
        //Consumer high = new HighInc();


        //standard.PayBill(120);   // Standard user
        //low.PayBill(120);        // Lower income user
        //high.PayBill(120);

        ////Abstract Tut.cs


        //// Ywe can't do this:
        //BankAccount acc = new BankAccount(); // (Compiler Error;can not be insatantiated)

        //// But ywe can do this:
        //BankAccount acc = new SavingAccount();

        //acc.Deposit();    // Output: Amount deposited...
        //acc.Withdraw();   // Output: Amount withdrawn...
        //acc.Balance();    // Output: Balance in saving account
        //acc.GetMessage(); // Output: Welcome to ABC Bank.


        //// Interfaces Tut
        //Console.WriteLine("\nInterfaces \n");
        //IBankAccount myAccount = new SavingAcct();

        //myAccount.addBalance(1000);
        //myAccount.addBalance(340);
        //myAccount.withDraw(400);
        //myAccount.CloseAccount();
        //Console.WriteLine("Balance is: " + myAccount.GetBalance());


        //Static
        Console.WriteLine(Calculate.Increment()); // 1
        Console.WriteLine(Calculate.Increment()); // 2
        Console.WriteLine(Calculate.Decrement()); // 1
        Console.WriteLine("Final Count: " + Calculate.GetCount());


        //Extension methods

        int number = 100;

        bool result = number.IsGreaterThan(1000);

        Console.WriteLine($"Is {number} greater than 1000? {result}");

        // Try with another value
        Console.WriteLine(number.IsGreaterThan(10)); //  True

        bool result2 = number.IsSmallerThan(23);
        Console.WriteLine($"Is {number} smaller than 23 {result2}");

        bool result3= number.IsSmallerThan(120);
        Console.WriteLine($"Is {number} smaller than 120 {result3}");


        //Extension methods

        PartialEmployee emp = new PartialEmployee
        {
            EmployeeID = 101,
            EmployeeName = "Ali"
        };

        emp.Show();


        // Property Csharp

        Patient p = new Patient();
        p.Name = "Ali";
        p.PatientID = 123;
        p.Age = 15;  //  "Invalid age"
        p.Age = 25;  // Valid


        Console.WriteLine($"Patient: {p.Name}, ID: {p.PatientID}");
        Console.WriteLine("User works as " + p.Job);
        Console.WriteLine("The age of user is " + p.Age);

        // Indexers
        StringIndexers index = new StringIndexers();
        index[0] = "First thing";
        index[1] = "Second thing";
        index[5] = "5th thing";
       


        Console.WriteLine("\n"+index[0]);  // Output: Hello
        Console.WriteLine(index[1]);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Index {i}: {index[i]}");
        }


        //enums

        EnumDemo enumDemo = new EnumDemo();
        enumDemo.DisplayDays();

        //exceptions
        Console.WriteLine("\tExceptions in Csharp");
        Calculation cal = new Calculation();
        cal.Calculate(120, 5);
        cal.Calculate(120, 10);
        //cal.CalculateAnother();

        //Anonymous

        AnonymousT run = new AnonymousT();
        run.anom();

        //Delegates

        Console.WriteLine("\nDelegates");

        // Point delegate to Addition method
        CalculateDelegate calculate = new CalculateDelegate(Delegates.Addition);
        Console.WriteLine("After Addition: " + calculate(20)); 

        // Point delegate to Multiplication method
        calculate = new CalculateDelegate(Delegates.Multiplication);
        Console.WriteLine("After Multiplication: " + calculate(10)); // 15 * 2 = 30

        // Display the final number
        Console.WriteLine("Final number: " + Delegates.GetNumber()); // Output: 30

        // multi-cast

        Console.WriteLine("\nMulticst delegate");
        CalculateDelegate calculate2 = Delegates.Addition;
        calculate2 += Delegates.Multiplication;

        // Call the multicast delegate
        calculate2(5);

        // Show final result
        Console.WriteLine("Final number: " + Delegates.GetNumber());

        //Delegates2

      

        //Events

        Console.WriteLine("\nEvents");

        EventsExample ev = new EventsExample();
        ev.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);
        ev.addition();
        Console.ReadLine();

        static void EventMessage()
        {
            Console.WriteLine("Event executed:Odd number");
        }

        //Anonymous Methods
        Console.WriteLine("\nAMs");
        AnonymousMethodExample.InvokeMethod();

    }
}


