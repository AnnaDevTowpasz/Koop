using MediatR;

namespace Koop.Aplication.Suppliers.Querries.GetSupplierDetail
{
    public class GetSupplierDetailQuery : IRequest<SupplierDetailVm>
    {
        public int SupplierId { get; set; }
    }
}
