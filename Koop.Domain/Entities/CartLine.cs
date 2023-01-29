using Koop.Domain.Common;

namespace Koop.Domain.Entities
{
    public class CartLine : AuditableEntity
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
        public EUnit EUnit { get; set; }
        public decimal Price { get; set; }
        public decimal Value { get; set; }
    }
}
