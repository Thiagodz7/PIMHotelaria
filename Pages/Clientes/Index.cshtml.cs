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
    public class IndexModel : PageModel
    {
        private readonly PIMHotelaria.Data.PIMHotelariaContext _context;

        public IndexModel(PIMHotelaria.Data.PIMHotelariaContext context)
        {
            _context = context;
        }

        public IList<Clientes> Clientes { get;set; }

        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }
    }
}
