using Covert_Orca.domain.Catalog;

namespace Covert_Orca.domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Item Item { get; get; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}