/*Types of Polymorphism in C#:
Compile-time Polymorphism
 Also called Static Polymorphism / Early Binding
 Achieved by:

Method Overloading

Constructor Overloading*/


using System;

class Person
{
    public int baseAmount = 5000;

   
    public void PayBill()
    {
        Console.WriteLine("Base amount to be paid: " + baseAmount);
    }

    public void PayBill(int discountPercent)
    {
        int amount = baseAmount - (baseAmount * discountPercent / 100);
        Console.WriteLine($"Pay after {discountPercent}% discount: {amount}");
    }

    public void PayBill(int AddTax, string userType)
    {
        Console.WriteLine($"{userType} has to pay a total amount of {AddTax+baseAmount}");
    }
}

//Constructor Overlaoding
class Parent
{
    public string childName;
    public int childAge;

    public Parent()
    {
        childName="Unknown";

        childAge=10;
        Console.WriteLine($"Child's name is {childName} and his age is {childAge}");

    }
    public Parent(string CN)
    {
        childName=CN;
        childAge= 0;
        Console.WriteLine($"Child's name is {childName} and his age is {childAge}");
    }
    public Parent(string CN,int CA)
    {
        childName=CN;
        childAge= CA;
        Console.WriteLine($"Child's name is {childName} and his age is {childAge}");
    }

}

/* Polymorphism (Dynamic Polymorphism)
 used inheritance: LowerInc and HighInc inherit from Consumer.

 used the virtual keyword in the base class method PayBill(int units).

 used the override keyword in the child classes.

The method PayBill() is the same in name and signature, but its behavior differs depending on the object type at runtime.*/

public class Consumer
{
    public virtual void PayBill(int units)
    {
        Console.WriteLine("Standard user has to pay " + (units * 10) + " rps");
    }
}

public class LowerInc : Consumer
{
    public override void PayBill(int units)
    {
        Console.WriteLine("Lower income user has to pay " + (units * 8) + " rps");
    }
}

public class HighInc : Consumer
{
    public override void PayBill(int units)
    {
        Console.WriteLine("High income user has to pay " + (units * 13) + " rps");
    }
}
