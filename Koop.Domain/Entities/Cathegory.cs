using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Cathegory : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
