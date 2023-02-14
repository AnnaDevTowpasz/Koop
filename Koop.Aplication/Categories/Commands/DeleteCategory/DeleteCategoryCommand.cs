using MediatR;

namespace Koop.Aplication.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest
    {
        public int CategoryId { get; set; }
    }
}
