using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Supplier : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; private set; } = new List<Product>();
    }
}
