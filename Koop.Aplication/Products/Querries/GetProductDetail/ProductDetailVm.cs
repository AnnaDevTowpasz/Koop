using AutoMapper;
using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;

namespace Koop.Aplication.Products.Querries.GetProductDetail
{
    public class ProductDetailVm : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public int? StoreId { get; set; }
        public Store Store { get; set; }
        public int StatusId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, ProductDetailVm>();
            //.ForMember(d => d.FullName, map => map.MapFrom(src => src.DirectorName.ToString()))
            //.ForMember(d => d.LastMovieName, map => map.MapFrom<LastMovieNameResolver>());
        }
    }
}
