using System;

namespace ATMApp;

class Account
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public double Balance { get; set; }

    public Account(string userId, double balance)
    {
        Id = Guid.NewGuid();
        UserId = Guid.Parse(userId);
        Balance = balance;
    }

    public void Withdraw(double amount)
    {
        Balance = -amount;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Pay(double amount)
    {
        Balance -= amount;
    }
}