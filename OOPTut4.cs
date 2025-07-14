//hierarchical inheritance

using System;

public class Faculty
{
    public string facultyName;
    public string facultyID;

    public void AcceptFacultyDetails()
    {
        Console.WriteLine("\n--- Enter Faculty Details ---");
        Console.Write("Faculty Name: ");
        facultyName = Console.ReadLine();

        Console.Write("Faculty ID: ");
        facultyID = Console.ReadLine();
    }

    public void Teach()
    {
        Console.WriteLine($"Faculty {facultyName} with ID {facultyID} is teaching.");
    }
}

public class Department : Faculty
{
    public string departmentName;
    public int totalCourses;

    public void AcceptDepartmentDetails()
    {
        Console.WriteLine("\n--- Enter Department Details ---");
        Console.Write("Department Name: ");
        departmentName = Console.ReadLine();

        Console.Write("Total Courses: ");
        totalCourses = int.Parse(Console.ReadLine());
    }

    public void ManageDepartment()
    {
        Console.WriteLine($"Department '{departmentName}' manages {totalCourses} courses and faculty {facultyName}.");
    }
}

public class MyStudent : Faculty
{
    public string studentName;
    public int rollNo;

    public void AcceptStudentDetails()
    {
        Console.WriteLine("\n--- Enter Student Details ---");
        Console.Write("Student Name: ");
        studentName = Console.ReadLine();

        Console.Write("Roll Number: ");
        rollNo = Convert.ToInt32(Console.ReadLine());
    }

    public void Study()
    {
        Console.WriteLine($"Student {studentName} with roll no. {rollNo} is studying under faculty {facultyName}.");
    }
}

