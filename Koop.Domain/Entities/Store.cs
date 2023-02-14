using Koop.Domain.Common;

namespace Koop.Domain.Entities
{
    public class Store : AuditableEntity
    {
        public int Quantity { get; set; }
        public EUnit Unit { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
