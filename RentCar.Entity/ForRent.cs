using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCar.Entity
{
    public class ForRent
    {
        
        public int ForRentId { get; set; }
        public DateTime RentDate { get; set; }
        public int FisrtKm { get; set; }
        public int LastKm { get; set; }
        public int ReceivedFee { get; set; }//alınan ücreti anlamında 
        public DateTime SaveTime { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
