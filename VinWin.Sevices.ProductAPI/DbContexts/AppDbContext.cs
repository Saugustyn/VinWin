using Microsoft.EntityFrameworkCore;
using VinWin.Sevices.ProductAPI.Models;

namespace VinWin.Sevices.ProductAPI.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
