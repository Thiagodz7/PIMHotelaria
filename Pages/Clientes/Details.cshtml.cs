using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PIMHotelaria.Data;

namespace PIMHotelaria.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public DetailsModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        public Clientes Clientes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clientes = await _context.Clientes.FirstOrDefaultAsync(m => m.ID == id);

            if (Clientes == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
