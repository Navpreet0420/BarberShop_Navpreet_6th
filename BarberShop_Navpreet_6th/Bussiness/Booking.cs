using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop_Navpreet_6th.Bussiness
{
    public class Booking
    {
        public int ID { get; set; }
        public int BarberStaffID { get; set; }
        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public BarberStaff BarberStaff { get; set; }
        public Customer Customer { get; set; }
    }
}
