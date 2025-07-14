using System;

class Vehicle
{
    public string color;
    public string vehicleType;
    public string MakeBy;

    public void AcceptDetails()
    {
        Console.WriteLine("Enter the color of the vehicle:");
        color = Console.ReadLine();

        Console.WriteLine("Enter the vehicle type:");
        vehicleType = Console.ReadLine();

        Console.WriteLine("Enter the manufacturer of this vehicle:");
        MakeBy = Console.ReadLine();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Vehicle Color: {color}, Type: {vehicleType}, Manufacturer: {MakeBy}");
    }
}

class Car : Vehicle
{
    private string model;
    private int price;
    private string owner;

    public Car(string m, int p, string o)
    {
        model = m;
        price = p;
        owner = o;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Model: {model}, Price: {price}, Owner: {owner}");
    }
}


    
