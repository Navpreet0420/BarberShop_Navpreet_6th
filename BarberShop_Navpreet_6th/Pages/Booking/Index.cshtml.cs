using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarberShop_Navpreet_6th.Bussiness;
using BarberShop_Navpreet_6th.Data;

namespace BarberShop_Navpreet_6th.Pages.Booking
{
    public class IndexModel : PageModel
    {
        private readonly BarberShop_Navpreet_6th.Data.ApplicationDbContext _context;

        public IndexModel(BarberShop_Navpreet_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Bussiness.Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Bookings
                .Include(b => b.BarberStaff)
                .Include(b => b.Customer).ToListAsync();
        }
    }
}
