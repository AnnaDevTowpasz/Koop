using Koop.Shared.Dictionaries.Commands;
using System.Collections.Generic;

namespace Koop.Shared.Suppliers.Commands
{
    public class SupplierVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Cathegory> Cathegories { get; set; }
    }
}
