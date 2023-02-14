using Koop.Domain.Common;

namespace Koop.Domain.Entities
{
    public class OrderPriceQuantity : AuditableEntity
    {
        public int Quantity { get; set; }
        public int AdditionalQuantity { get; set; }
        public EUnit Unit { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
