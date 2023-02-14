using Koop.Aplication.Common.Interfaces;
using Koop.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Koop.Aplication.Categories.Commands.CreateCategory
{
    class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly IKoopDbContext _context;
        public CreateCategoryCommandHandler(IKoopDbContext koopDbContext)
        {
            _context = koopDbContext;
        }

        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                StatusId = request.StatusId
            };

            _context.Categories.Add(category);

            await _context.SaveChangesAsync(cancellationToken);

            return category.Id;
        }
    }
}
