using cp5.model;
using Microsoft.EntityFrameworkCore;


namespace cp5.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Aline\Desktop\facul\3ESR\C#\cp5\cp5\todo.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .HasMany(c => c.Tarefas)
                .WithOne(t => t.Categorias!)
                .HasForeignKey(t => t.CategoriaId);
        }
    }
}
