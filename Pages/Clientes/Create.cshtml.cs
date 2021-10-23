using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PIMHotelaria.Data;

namespace PIMHotelaria.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public CreateModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Clientes Clientes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clientes.Add(Clientes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
