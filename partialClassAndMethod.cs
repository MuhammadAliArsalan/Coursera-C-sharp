using System;

public partial class PartialEmployee
{
    public int EmployeeID;
    public string EmployeeName;

    partial void EmployeeDetails();  // Declaration only
}
