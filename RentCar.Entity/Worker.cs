using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCar.Entity
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public int Password { get; set; }
        public string email { get; set; }
        public DateTime SaveTime { get; set; }


        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
