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
    public class DeleteModel : PageModel
    {
        private readonly BarberShop_Navpreet_6th.Data.ApplicationDbContext _context;

        public DeleteModel(BarberShop_Navpreet_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bussiness.Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings
                .Include(b => b.BarberStaff)
                .Include(b => b.Customer).FirstOrDefaultAsync(m => m.ID == id);

            if (Booking == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings.FindAsync(id);

            if (Booking != null)
            {
                _context.Bookings.Remove(Booking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
