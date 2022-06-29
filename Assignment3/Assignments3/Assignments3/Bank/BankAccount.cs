using System;
namespace Assignments3.Bank
{
    public class BankAccount
    {
      public string AccountTitle { get; set; } //Sahib yar
      public string AccountNumber { get; set; }  //004167177459
      public AccountType AccountType { get; set; } //curretnt,saving,fixed
      public double Balance{ get; set; } //550.34
      public string BranchCode { get; set; } //0504
      public string BranchName { get; set; } //Main Branch
      public  BankAccount()
      {
            AccountTitle = "Sahib yar";
            AccountNumber = "004167177459";
            AccountType = AccountType.Current;
            Balance = 550.34;
            BranchCode = "0504";
            BranchName = "MainBranch";
      }
        public void Deposit(double Amount)
        {
            Console.WriteLine("Deposit Function");
            //1500+700
            Balance =  Balance + Amount;
            Console.WriteLine("Current Balanc:" + Balance);
        }
        public void WithDraw(double Amount)
        {
            Console.WriteLine("WithDraw Function");
            //1500-700
            Balance = Balance - Amount;
            Console.WriteLine("Current Balance:" + Balance);
        }

    } 
}
