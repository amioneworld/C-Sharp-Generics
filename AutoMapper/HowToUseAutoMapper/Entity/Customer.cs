using System;
using System.Collections.Generic;
using System.Text;

namespace HowToUseAutoMapper
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }

        public string Name() => $"{FirstName} {LastName}";
        
    }
}
