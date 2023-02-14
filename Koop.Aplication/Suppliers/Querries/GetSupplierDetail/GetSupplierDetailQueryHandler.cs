using AutoMapper;
using Koop.Aplication.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Suppliers.Querries.GetSupplierDetail
{
    class GetSupplierDetailQueryHandler : IRequestHandler<GetSupplierDetailQuery, SupplierDetailVm>
    {
        private readonly IKoopDbContext _context;
        private IMapper _mapper;
        //private readonly ICurrentUserService _userService;
        public GetSupplierDetailQueryHandler(IKoopDbContext koopDbContext, IMapper mapper) //, ICurrentUserService userService)
        {
            _context = koopDbContext;
            _mapper = mapper;
            //_userService = userService;
        }
        public async Task<SupplierDetailVm> Handle(GetSupplierDetailQuery request, CancellationToken cancellationToken)
        {
            var supplier = await _context.Suppliers.Include(p => p.Products).Where(p => p.Id == request.SupplierId).FirstOrDefaultAsync(cancellationToken);

            var supplierVm = _mapper.Map<SupplierDetailVm>(supplier);

            return supplierVm;
        }
    }
}
