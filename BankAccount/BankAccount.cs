﻿using System;
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

        //Lycka till! :)
    }
}
