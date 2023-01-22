using System.Collections.Generic;

namespace Koop.Shared.Products.Commands
{
    class GroupListVM
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<ProductInCartVM> ProductList { get; set; }
    }
}
