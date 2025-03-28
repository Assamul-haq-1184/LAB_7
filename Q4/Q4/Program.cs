using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount A1 = new BankAccount();
            BankAccount A2 = new BankAccount();
            BankAccount A3 = new BankAccount();
            BankAccount A4 = new BankAccount();
           
            Console.WriteLine("\t\t\t\t\t-----BANK ACCOUNTS DETAIL----- ");
            Console.WriteLine("Account number 1 details:");
            A1.Deposit_Amount(1000);
            A1.Withdraw_amount(500);
            Console.WriteLine("\nAccount number 2 details:");
            A2.Deposit_Amount(50000);
            A2.Withdraw_amount(10000);
            Console.WriteLine("\nAccount number 3 details:");
            A4.Deposit_Amount(10000);
            A4.Withdraw_amount(11000);
            Console.WriteLine("\nAccount number 4 details:");
            A3.Deposit_Amount(300000);

            Console.WriteLine($"\nTotal Account are {BankAccount.Get_total_accounts()}");

        }
    }
}
