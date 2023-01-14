using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
