using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArtMarketplace.Data.Contexts
{
    public class ArtContext : DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
