using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public int? StoreId { get; set; }
        public Store Store { get; set; }
        public List<OrderPriceQuantity> OrderQuantities { get; private set; } = new List<OrderPriceQuantity>();
        public int StatusId { get; set; }
    }

    public enum EUnit { kg, szt, peczek }
}
