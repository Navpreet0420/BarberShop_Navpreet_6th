﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop_Navpreet_6th.Bussiness
{
    public class BarberStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Booking> Booking { get; set; }
    }
}
