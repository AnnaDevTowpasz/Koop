using Koop.Domain.Common;
using Koop.Domain.ValueObjects;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public OrderName OrderName { get; set; }
        public int DictionaryOrderStatusId { get; set; }
        public DictionaryOrderStatus DictionaryOrderStatus { get; set; }
        public List<OrderUserStatus> OrderUserStatuses { get; private set; } = new List<OrderUserStatus>();
        public List<OrderPriceQuantity> OrderQuantities { get; private set; } = new List<OrderPriceQuantity>();
        public List<Cart> Carts { get; private set; } = new List<Cart>();
    }
}
