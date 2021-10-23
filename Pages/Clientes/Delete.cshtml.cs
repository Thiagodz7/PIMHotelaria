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
    public class DeleteModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public DeleteModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clientes = await _context.Clientes.FindAsync(id);

            if (Clientes != null)
            {
                _context.Clientes.Remove(Clientes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
