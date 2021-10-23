using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PIMHotelaria.Data;

namespace PIMHotelaria.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public EditModel(PIMHotelaria.Data.PIMHotelariaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Clientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesExists(Clientes.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.ID == id);
        }
    }
}
