using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCar.Entity
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int Price { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime OutputDate { get; set; }
        public DateTime SaveTime { get; set; }
        public bool isRent { get; set; }

        
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
