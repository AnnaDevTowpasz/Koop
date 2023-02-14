using Koop.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Koop.Aplication.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Store Store { get; set; }
        public List<OrderPriceQuantity> OrderQuantities { get; private set; } = new List<OrderPriceQuantity>();
        public int StatusId { get; set; }
    }
}
