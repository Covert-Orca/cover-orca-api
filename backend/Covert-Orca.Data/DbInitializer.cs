using Covert_Orca.domain.Catalog;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Covert_Orca.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context, ILogger logger)
        {
            if (!context.Items.Any())
            {
                var items = new Item[]
                {
                    new Item("T-Shirt", "Ohio State Block O", "Nike", "/images/da.jpg", 39.99m),
                    new Item("Shorts", "Casual shorts", "Nike", "/images/d1.jpg", 49.99m)
                };
            
            context.Items.AddRange(items);
            context.SaveChanges();
            }
        }
    }
}
