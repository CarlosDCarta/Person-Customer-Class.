using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Promgramming_assign._5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string HouseNumber { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }

        public Person()
        {

        }

        //Contructor
        public Person(string firstName, string middleName, string lastName, string houseNumber, string streetAddress, string streetAddress2, string city,
            string state, string zipCode, string emailAddress)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            HouseNumber = houseNumber;
            StreetAddress = streetAddress;
            StreetAddress2 = streetAddress2;
            City = city;
            State = state;
            ZipCode = zipCode;
            EmailAddress = emailAddress;
        }

        public void ShippingLabel()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
            Console.WriteLine($"{HouseNumber} {StreetAddress} {City} {State} {ZipCode}");

        }
        
            
        
    }
}
