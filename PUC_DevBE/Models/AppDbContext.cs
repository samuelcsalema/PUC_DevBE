using Microsoft.EntityFrameworkCore;

namespace PUC_DevBE.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Veículo> Veiculos { get; set; }

    }
}
