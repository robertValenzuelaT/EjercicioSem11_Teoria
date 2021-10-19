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
        
        
        public DbSet<Producto> DataProductos { get; set; }
        public DbSet<Categoria> DataCategorias { get; set; }

        
    }
}
