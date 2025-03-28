using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class BankAccount
    {
        private static int Total_Accounts=0;
        private double balance;

       
        public BankAccount() 
        {
            Total_Accounts++;
            balance = 0;
        }
        public void Deposit_Amount(double Amount)
        {
            if (Amount > 0) {
                balance += Amount;
                Console.WriteLine($"New balance is {balance}");
            }
            else { Console.WriteLine($"You enter Wrong amount."); }
        }
        public void Withdraw_amount(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"You withdraw RS{amount} , New Balance ={balance}");
            }
            else { Console.WriteLine("Your Balance is insufficient."); }
        }
       public static double Get_total_accounts()
        {
            return Total_Accounts;
        } 

    }
}
