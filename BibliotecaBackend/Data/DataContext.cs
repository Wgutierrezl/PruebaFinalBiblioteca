using Microsoft.EntityFrameworkCore;
using BibliotecaControlador.Entities;

namespace BibliotecaBackend.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
			modelBuilder.Entity<Prestamo>()
		   .ToTable(tb => tb.UseSqlOutputClause(false));
		}
    }
}
