using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PIMHotelaria.Data;

namespace PIMHotelaria.Pages.Reservas
{
    public class DetailsModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public DetailsModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        public Reservas Reservas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reservas = await _context.Reservas.FirstOrDefaultAsync(m => m.ID == id);

            if (Reservas == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
