using System;
namespace Assignments3.Bank
{
    internal class AccountManager
    {
        public void Run()
        {
            BankAccount account = new BankAccount();
            account.Deposit(500);
            account.WithDraw(1000);
        }
    }
}
