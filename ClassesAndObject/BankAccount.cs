using System;

namespace ClassesAndObject;

public class BankAccount
{
    private string _accountNumber;
    private decimal _balance;

    public BankAccount(string accountNumber, decimal balance)
    {
        _accountNumber = accountNumber;
        _balance = balance;
    }

    public string GetAccountNumber()
    {
        return _accountNumber;
    }

    public decimal GetBalance()
    {
        return _balance;
    }


    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
        }
    }
}
