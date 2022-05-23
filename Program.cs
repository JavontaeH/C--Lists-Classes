using System;

using System.Collections.Generic;

namespace stringList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Address> AddressList = new List<Address>
            {
                new Address {
                    Street = "101 Main Street",
                    City = "Nashville",
                    Zip = 37013
                },
                new Address {
                    Street = "102 Main Street",
                    City = "Nashville",
                    Zip = 37213
                },
                new Address {
                    Street = "103 Main Street",
                    City = "Nashville",
                    Zip = 37313
                },
                new Address {
                    Street = "104 Main Street",
                    City = "Nashville",
                    Zip = 37413
                }

            };

            foreach (Address address in AddressList)
            {
                Console.WriteLine(address.Street + ", " + address.City + ", " + address.Zip);
            }




        }
    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
    }
}
