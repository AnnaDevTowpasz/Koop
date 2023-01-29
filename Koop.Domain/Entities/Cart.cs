using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class Cart : AuditableEntity
    {
        public int BoxNumber { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DictionaryCartStatus DictionaryCartStatus { get; set; }
        public List<CartLine> CartLines { get; private set; } = new List<CartLine>(); 
    }
}
