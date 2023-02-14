using MediatR;
using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Suppliers.Querries.GetSuppliersQuery
{
    public class GetSuppliersQueryHandler : IRequestHandler<GetSuppliersQuery, SuppliersVM>
    {
        private readonly IKoopDbContext _context;
        private readonly IMapper _mapper;

        public GetSuppliersQueryHandler(IKoopDbContext koopDbContext, IMapper mapper)
        {
            _context = koopDbContext;
            _mapper = mapper;
        }

        public async Task<SuppliersVM> Handle(GetSuppliersQuery request, CancellationToken cancellationToken)
        {
            var suppliers = _context.Categories.OrderBy(p => p.Name).ToList();
            var suppliersVM = new SuppliersVM()
            {
                Suppliers = suppliers.Select(p => _mapper.Map<SupplierDto>(p)).ToList()
            };

            return suppliersVM;
        }
    }
}
