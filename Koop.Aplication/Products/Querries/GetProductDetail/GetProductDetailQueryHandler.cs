using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Products.Querries.GetProductDetail
{
    class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetailVm>
    {
        private readonly IKoopDbContext _context;
        private IMapper _mapper;
        //private readonly ICurrentUserService _userService;
        public GetProductDetailQueryHandler(IKoopDbContext koopDbContext, IMapper mapper) //, ICurrentUserService userService)
        {
            _context = koopDbContext;
            _mapper = mapper;
            //_userService = userService;
        }
        public async Task<ProductDetailVm> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.Where(p => p.Id == request.ProductId).FirstOrDefaultAsync(cancellationToken);

            var productVm = _mapper.Map<ProductDetailVm>(product);

            return productVm;
        }
    }
}
