using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        //Lägg till Konstruktor

        public BankAccount (string accountnumber, string accountholder, decimal balance)
        {
            AccountNumber = accountnumber;
            AccountHolder = accountholder;
            Balance = balance;
        }

        //Lägg till Metoder
        //Metod för att sätta in pengar på konto
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Du måste ange ett positivt belopp");
            }
            
        }

        //Metod för att ta ut pengar från kontot om det går
        public void Withdraw(decimal withdraw)
        {
            if (withdraw <= 0)
            {
                Console.WriteLine("Du måste ange ett positivt belopp");
            }
            else if (withdraw <= Balance)
            {
                Balance -= withdraw;
            }
            else
            {
                Console.WriteLine("Det går inte att genomföra uttaget");
            }
        }

        //Metod för att visa aktuellt belopp
        public void DisplayBalance()
        {
            Console.WriteLine($"Saldo: {Balance} kr");
        }

        //Lycka till! :)
    }
}
