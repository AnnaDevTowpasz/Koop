using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Categories.Querries.GetCategoryDetail
{
    public class GetCategoryDetailQueryHandler : IRequestHandler<GetCategoryDetailQuery, CategoryDetailVm>
    {
        private readonly IKoopDbContext _context;
        private IMapper _mapper;
        //private readonly ICurrentUserService _userService;
        public GetCategoryDetailQueryHandler(IKoopDbContext koopDbContext, IMapper mapper) //, ICurrentUserService userService)
        {
            _context = koopDbContext;
            _mapper = mapper;
            //_userService = userService;
        }
        public async Task<CategoryDetailVm> Handle(GetCategoryDetailQuery request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.Include(p => p.Products).Where(p => p.Id == request.CategoryId).FirstOrDefaultAsync(cancellationToken);

            var categoryVm = _mapper.Map<CategoryDetailVm>(category);

            return categoryVm;
        }
    }
}
