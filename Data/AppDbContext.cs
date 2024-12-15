using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticaClase.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticaClase.Models.Proveedor> Proveedores { get; set; } = default!;

        public DbSet<PracticaClase.Models.Producto> Productos { get; set; } = default!;
    }
