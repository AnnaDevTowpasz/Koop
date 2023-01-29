using Koop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.Aplication.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<Category> Categories { get; private set; } = new List<Category>();
        public EUnit Unit { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
    }

}
