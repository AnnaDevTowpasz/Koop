using MediatR;
using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Categories.Querries.GetCategoriesQuery
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, CategoriesVM>
    {
        private readonly IKoopDbContext _context;
        private readonly IMapper _mapper;

        public GetCategoriesQueryHandler(IKoopDbContext koopDbContext, IMapper mapper)
        {
            _context = koopDbContext;
            _mapper = mapper;
        }

        public async Task<CategoriesVM> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = _context.Categories.OrderBy(p => p.Name).ToList();
            var categoriesVM = new CategoriesVM()
            {
                Categories = categories.Select(p => _mapper.Map<CategoryDto>(p)).ToList()
            };

            return categoriesVM;
        }
    }
}
