using System;
using System.Text;

public class StringTut
{
    public static void String1()
    {
        Console.WriteLine("\nEnter your name");
        string myName=Console.ReadLine();


        //Contains()
        string myBrotherName = "Hasan";
        bool ConatinsLetter= myName.Contains('i');

        int lengthOfName=myName.Length;
        Console.WriteLine("The lnegth of my name is " + lengthOfName);

        if (ConatinsLetter)
        {
            Console.Write("Great");
        }
        else
        {
            Console.WriteLine("The letter 'i' is not in your name.");
        }


        //Replace(oldValue, newValue)
        string myFavDish1 = "Biryani";

        String myOtherFavDish = myFavDish1.Replace(myFavDish1, "Pulao");

        Console.WriteLine("\nMy favorite dish is "+myOtherFavDish);


        //ToUpper, ToLower

        Console.WriteLine("Name in upper case "+myName.ToUpper());
        Console.WriteLine("Name in lower case "+myName.ToLower());

        //Substring(startIndex, length)

        string myCountry = "Pakistan";
        string part = myCountry.Substring(0, 6);
        Console.WriteLine("After slicing " + myCountry + " we get " + part);

        string names = "Ali Ahmed Sara";
        string[] nameList = names.Split("__");

        foreach (string n in nameList)
        {
            Console.WriteLine(n);
        }

        string myLastName = " Arslan";
        string fullName = string.Concat(myName, myLastName);
        Console.WriteLine("\nMy full name is " + fullName);

     
        //Immutable String

        string myBike = "CD70";
        myBike += " Honda";  //Since string is immutable, this line creates a new string object with value "CD70 Honda" and assigns it to myBike
        Console.WriteLine("My bike is " + myBike);

        //Behind the scenes: "Ali" and "Ali Khan" are two different objects.



        //Mutable String

        StringBuilder sb = new StringBuilder("Ali");
        sb.Append(" Khan");  // Modifies the same object
        Console.WriteLine(sb);  // Output: Ali Khan







    }
}