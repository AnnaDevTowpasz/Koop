using MediatR;

namespace Koop.Aplication.Products.Querries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<ProductDetailVm>
    {
        public int ProductId { get; set; }
    }
}
