using Koop.Aplication.Common.Interfaces;
using Koop.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IKoopDbContext _context;
        public CreateProductCommandHandler(IKoopDbContext koopDbContext)
        {
            _context = koopDbContext;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Supplier = request.Supplier,
                SupplierId = request.SupplierId,
                StatusId = request.StatusId
            };

            _context.Products.Add(product);

            await _context.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
