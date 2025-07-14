using System;

public abstract class BankAccount
{
    public abstract void Deposit();
    public abstract void Withdraw();
    public abstract void Balance();

    // Non-abstract method (has body)
    public void GetMessage()
    {
        Console.WriteLine("Welcome to ABC Bank.");
    }
}
public class SavingAccount : BankAccount
{
    public override void Deposit()
    {
        Console.WriteLine("Amount deposited in saving account.");
    }

    public override void Withdraw()
    {
        Console.WriteLine("Amount withdrawn from saving account.");
    }

    public override void Balance()
    {
        Console.WriteLine("Balance in saving account.");
    }
}

/*
 | Rule                       | Explanation                                                |
| -------------------------- | ---------------------------------------------------------- |
| `abstract class`           | Can't be instantiated directly.                            |
| `abstract method`          | Must be overridden in derived class.                       |
| Class with abstract method | Must itself be abstract.                                   |
| Abstract class can have    | Both abstract and non-abstract methods.                    |
| Use of `override`          | Required in the child class to implement abstract methods. |

 */
