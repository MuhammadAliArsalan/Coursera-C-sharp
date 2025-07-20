using System;

public interface IBankAccount
{
    void addBalance(double amount);
    void withDraw(double amount);
    void CloseAccount();
    double GetBalance();
}

public class SavingAcct : IBankAccount
{
    public double balance = 0;

    public void addBalance(double amount)
    {
        balance = balance + amount;
        Console.WriteLine($"You deposited {amount} and your balance is now {balance}");
    }

    public void withDraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"You withdrew {amount} and remaining balance is {balance}");
        }
    }
    

    public double GetBalance()
    {
        return balance;
    }
    public void CloseAccount()
    {
        balance = 0;
        Console.WriteLine("Your account has been closed. Final balance is 0.");
    }

}
