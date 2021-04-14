using Covert_Orca.domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Covert_Orca.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
            { }

            public DbSet<Item> Items { get; set;}

            public DbSet<Order> Orders { get; set; }
    }
}
