using AutoMapper;
using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;
using System.Collections.Generic;

namespace Koop.Aplication.Suppliers.Querries.GetSupplierDetail
{
    public class SupplierDetailVm : IMapFrom<Supplier>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; private set; } = new List<Product>();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Supplier, SupplierDetailVm>();
            //.ForMember(d => d.FullName, map => map.MapFrom(src => src.DirectorName.ToString()))
            //.ForMember(d => d.LastMovieName, map => map.MapFrom<LastMovieNameResolver>());
        }
    }
}
