using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Customer
    {//field
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        //property
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        //CTOR
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }

        public override string ToString()
        {
            return string.Format($"\nCustomer ID: {CustomerId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nContact Information: {ContactInformation}");
        }


    }//end Class
}//end Namespace
