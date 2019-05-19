using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCar.Entity
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int CarCount { get; set; }


        public List<Car> Cars { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
