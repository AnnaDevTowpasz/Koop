using AutoMapper;
using Koop.Aplication.Common.Mappings;
using Koop.Domain.Entities;
using System.Collections.Generic;

namespace Koop.Aplication.Categories.Querries.GetCategoryDetail
{
    public class CategoryDetailVm : IMapFrom<Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; private set; } = new List<Product>();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryDetailVm>();
                //.ForMember(d => d.FullName, map => map.MapFrom(src => src.DirectorName.ToString()))
                //.ForMember(d => d.LastMovieName, map => map.MapFrom<LastMovieNameResolver>());
        }

        //private class LastMovieNameResolver : IValueResolver<Director, object, string>
        //{
        //    public string Resolve(Director source, object destination, string destMember, ResolutionContext context)
        //    {
        //        if (source.Movies is not null && source.Movies.Any())
        //        {
        //            var lastMovie = source.Movies.OrderByDescending(p => p.PremiereYear).FirstOrDefault();
        //            return lastMovie.Name;
        //        }
        //        return string.Empty;
        //    }
        //}
    }
}
