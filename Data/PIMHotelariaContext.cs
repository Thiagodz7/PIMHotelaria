using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIMHotelaria.Pages.Clientes;
using PIMHotelaria.Pages.Contas;
using PIMHotelaria.Pages.Reservas;

namespace PIMHotelaria.Data
{
    public class PIMHotelariaContext : DbContext
    {
        public PIMHotelariaContext (DbContextOptions<PIMHotelariaContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD

=======
>>>>>>> 5a316e225dec6afeee766a1be7c9250a0f695d96
        public DbSet<PIMHotelaria.Pages.Clientes.Clientes> Clientes { get; set; }

        public DbSet<PIMHotelaria.Pages.Contas.Contas> Contas { get; set; }

        public DbSet<PIMHotelaria.Pages.Reservas.Reservas> Reservas { get; set; }
    }
}
