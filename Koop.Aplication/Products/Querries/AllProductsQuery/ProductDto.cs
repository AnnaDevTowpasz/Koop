using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.Aplication.Products.Querries.AllProductsQuery
{
    public class ProductDto : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EUnit Unit { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<Product, ProductDto>();
                //.ForMember(d => d.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
