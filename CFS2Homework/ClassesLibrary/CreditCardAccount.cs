using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class CreditCardAccount 
    {
        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = false;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount() { }

        public override string ToString()
        {
            return string.Format("Account Number: {0}\nCustomer Information: {1}\nBalance: {2}\nIs past due: {3}\nAnnual Interest Rate: {4}",
                AccountNumber,
                CustomerInfo,
                Balance,
                IsPastDue ? "No" : "Yes",
                AnnualInterestRate);
        }

    }//end Class
}//end Namespace
