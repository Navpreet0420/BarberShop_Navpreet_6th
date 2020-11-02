using System;
using System.Collections.Generic;
using System.Text;
using BarberShop_Navpreet_6th.Bussiness;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarberShop_Navpreet_6th.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<BarberStaff> BarberStaffs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
