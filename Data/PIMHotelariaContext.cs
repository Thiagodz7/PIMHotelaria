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

        public DbSet<PIMHotelaria.Pages.Clientes.Clientes> Clientes { get; set; }

        public DbSet<PIMHotelaria.Pages.Contas.Contas> Contas { get; set; }

        public DbSet<PIMHotelaria.Pages.Reservas.Reservas> Reservas { get; set; }
    }
}
