﻿using System;
namespace ClassesAndObjects.Accounting
{
    public class Account
    {
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
        }
    }
}
