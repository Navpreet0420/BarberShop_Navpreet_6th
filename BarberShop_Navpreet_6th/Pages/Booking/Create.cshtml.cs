using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BarberShop_Navpreet_6th.Bussiness;
using BarberShop_Navpreet_6th.Data;

namespace BarberShop_Navpreet_6th.Pages.Booking
{
    public class CreateModel : PageModel
    {
        private readonly BarberShop_Navpreet_6th.Data.ApplicationDbContext _context;

        public CreateModel(BarberShop_Navpreet_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BarberStaffID"] = new SelectList(_context.BarberStaffs, "ID", "Name");
        ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public Bussiness.Booking Booking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bookings.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
