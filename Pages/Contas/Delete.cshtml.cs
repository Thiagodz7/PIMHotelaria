using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PIMHotelaria.Data;

namespace PIMHotelaria.Pages.Contas
{
    public class DeleteModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public DeleteModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contas Contas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contas = await _context.Contas.FirstOrDefaultAsync(m => m.ID == id);

            if (Contas == null)
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

            Contas = await _context.Contas.FindAsync(id);

            if (Contas != null)
            {
                _context.Contas.Remove(Contas);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
