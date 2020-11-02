using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarberShop_Navpreet_6th.Bussiness;
using BarberShop_Navpreet_6th.Data;

namespace BarberShop_Navpreet_6th.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        private readonly BarberShop_Navpreet_6th.Data.ApplicationDbContext _context;

        public DetailsModel(BarberShop_Navpreet_6th.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Bussiness.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
