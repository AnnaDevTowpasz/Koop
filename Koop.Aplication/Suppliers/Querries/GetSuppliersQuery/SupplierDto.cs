using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;

namespace Koop.Aplication.Suppliers.Querries.GetSuppliersQuery
{
    public class SupplierDto : IMapFrom<Supplier>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<Supplier, SupplierDto>();
            //.ForMember(d => d.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
