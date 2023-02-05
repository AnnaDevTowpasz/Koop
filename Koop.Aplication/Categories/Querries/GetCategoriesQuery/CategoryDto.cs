using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;

namespace Koop.Aplication.Categories.Querries.GetCategoriesQuery
{
    public class CategoryDto : IMapFrom<Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<Category, CategoryDto>();
            //.ForMember(d => d.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
