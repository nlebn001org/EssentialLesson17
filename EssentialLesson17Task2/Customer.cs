using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson17Task2
{
    class Customer
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Customer(string brand, string name, int phoneNumber)
        {
            Brand = brand;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{Brand}, {Name}, {PhoneNumber}";
        }

    }
}
