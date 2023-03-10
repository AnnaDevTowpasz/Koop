using MediatR;

namespace Koop.Aplication.Categories.Querries.GetCategoryDetail
{
    public class GetCategoryDetailQuery : IRequest<CategoryDetailVm>
    {
        public int CategoryId { get; set; }
    }
}
