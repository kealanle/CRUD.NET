using CRUDweb.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDweb.Data;

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Planta> Plantas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }



}

