using Microsoft.EntityFrameworkCore;
using Site_loja.Models;

namespace Site_loja.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Lanche> Lanches {get; set;}
    }
}