using System;

public class Calculation
{
    public void Calculate(int num1,int num2)
    {
        int result = 0;
        try
        {
            result = num1 / num2;
          
        }
        catch(Exception ex)
        {
            Console.WriteLine("Exception occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("the result is " + result);
            Console.WriteLine("Program finsihed");
        }
    }
    public void CalculateAnother()
    {
        int num1 = 0, num2 = 0, result = 0;

        try
        {
            Console.Write("Enter Number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = int.Parse(Console.ReadLine());

            result = num1 / num2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input format error: " + ex.Message);
        }
        catch (Exception ex) // General catch for all other exceptions
        {
            Console.WriteLine("Some other error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Finally block executed.");
        }
    }
}