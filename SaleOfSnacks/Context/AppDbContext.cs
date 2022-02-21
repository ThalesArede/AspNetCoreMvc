using SaleOfSnacks.Models;
using Microsoft.EntityFrameworkCore;

namespace SaleOfSnacks.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; } // Game > Lanche / Games > Lanches
        public DbSet<Categoria> Categorias { get; set; }
    }
}