using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace F
{
    internal class Address
    {

        public Address() { }
        public Address(string country, string city, string street, int house, int apartment, int index)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }


        public int Index { get; set; } = 123;
        public string Country { get; set; } = "Ukraine";
        public string City { get; set; } = "";
        public string Street { get; set; } = "";
        public int House { get; set; }
        public int Apartment { get; set; }


    }
}
