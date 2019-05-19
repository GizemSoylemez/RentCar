using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCar.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public int Password { get; set; }
        public string email { get; set; }
        public DateTime SaveTime { get; set; }


        public int ForRentId { get; set; }
        public ForRent ForRent { get; set; }
    }
}
