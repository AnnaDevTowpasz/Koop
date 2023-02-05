using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Products.Querries.GetProductsQuery
{
    class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductsVM>
    {
        private readonly IKoopDbContext _context;
        private readonly IMapper _mapper;
        
        public GetProductsQueryHandler(IKoopDbContext koopDbContext, IMapper mapper)
        {
            _context = koopDbContext;
            _mapper = mapper;
        }

        public async Task<ProductsVM> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _context.Products.OrderByDescending(p => p.Name).ToList();
            var productsVM = new ProductsVM()
            {
                Products = products.Select(p => _mapper.Map<ProductDto>(p)).ToList()
                //products.Select(p => new ProductDto() { Name = p.Name, Description = p.Description, Unit = p.Unit, PricePerUnit = p.PricePerUnit }).ToList()
            };
            
            return productsVM;
        }
    }
}
