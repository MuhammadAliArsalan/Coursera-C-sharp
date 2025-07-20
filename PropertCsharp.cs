using System;

public class Patient
{
    private string name;
    private int patientID;
    private string job;
    private int age;

    public Patient()
    {
        job = "Doctor";
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int PatientID
    {
        get { return patientID; }
        set { patientID = value; }
    }
    public string Job
    {
        get { return job; }
    }
    public int Age
    {
        get { return age; }
        set {
            if (value < 18)
            {
                Console.WriteLine("Inavlid age");
            }
            else
            {
                age = value;
            }
       }
    }
}
