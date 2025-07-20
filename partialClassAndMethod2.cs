using System;

public partial class PartialEmployee
{
    partial void EmployeeDetails()  // Correct method definition
    {
        Console.WriteLine($"ID: {EmployeeID}, Name: {EmployeeName}");
    }

    public void Show()
    {
        EmployeeDetails();  // Call to the partial method
    }
}
