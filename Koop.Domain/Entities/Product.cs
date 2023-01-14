using Koop.Domain.Common;

namespace Koop.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public EUnit Unit { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Description { get; set; }
    }

    public enum EUnit { kg, szt }
}
