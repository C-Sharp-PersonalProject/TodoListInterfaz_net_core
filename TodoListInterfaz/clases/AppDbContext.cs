using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoListInterfaz.clases;


namespace TodoListInterfaz.clases
{
    public class AppDbContext : DbContext
    {
        DbSet<Tarea> Tareas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuración adicional del modelo si es necesario
        }
    }
}
