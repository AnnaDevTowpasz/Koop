using Koop.Domain.Common;
using Koop.Domain.ValueObjects;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class  User : AuditableEntity
    {
        public PersonName PersonName { get; set; }
        public Email Email { get; set; }
        public string Telefon { get; set; }
        public List<OrderUserStatus> OrderUserStatuses { get; private set; } = new List<OrderUserStatus>();
        public List<Cart> Carts { get; private set; } = new List<Cart>();
    }
}
