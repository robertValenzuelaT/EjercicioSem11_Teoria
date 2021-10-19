using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EjercicioSem11_Teoria.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        
        //public DbSet<SolicitudAdopcion> SolicitudesAdopcion { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }

        //public DbSet<PruebaMVCLogin.Models.Contact> DataContacts { get; set; }
        //public DbSet<PruebaMVCLogin.Models.Product> DataProducts { get; set; }
    }
}
