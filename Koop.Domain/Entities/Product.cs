using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<Category> Categories { get; private set; } = new List<Category>();
        public EUnit Unit { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Description { get; set; }
    }

    public enum EUnit { kg, szt }
}
