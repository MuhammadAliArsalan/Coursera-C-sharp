using System;

class AnonymousT
{
    public void anom()
    {
        var obj = new
        {
            firstName = "Ali",
            lastName = "Hasan",
            salary=12000,
            address=new {StreetName="S5",FlatNo=153,city="Karachi"},
            projects = new[]
            {
                new
                {
                    projectName="Ecommerce",duration="7days"
                },
                new
                {
                     projectName="Backend devp",duration="17days"
                }
            }

        };

        Console.WriteLine(obj.firstName);  // Output: Ali
        Console.WriteLine(obj.lastName);   // Output: Hasan
        Console.WriteLine("Person lives in street "+obj.address.StreetName+" and his flat number is "+obj.address.FlatNo);
       
        Console.WriteLine(obj.salary);
        Console.WriteLine("\nProjects:");
        foreach (var project in obj.projects)
        {
            Console.WriteLine("- " + project.projectName + " (" + project.duration + ")");
        }

    }
}
