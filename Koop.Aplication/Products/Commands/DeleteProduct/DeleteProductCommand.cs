using MediatR;

namespace Koop.Aplication.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int ProductId { get; set; }
    }
}
