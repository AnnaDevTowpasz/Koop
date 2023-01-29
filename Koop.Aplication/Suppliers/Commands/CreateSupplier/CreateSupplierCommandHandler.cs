using Koop.Aplication.Common.Interfaces;
using Koop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Suppliers.Commands.CreateSupplier
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, int>
    {
        private readonly IKoopDbContext _context;
        public CreateSupplierCommandHandler(IKoopDbContext koopDbContext)
        {
            _context = koopDbContext;
        }

        public async Task<int> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            Supplier supplier = new()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                StatusId = request.StatusId
            };

            _context.Suppliers.Add(supplier);

            await _context.SaveChangesAsync(cancellationToken);

            return supplier.Id;
        }
    }
}
