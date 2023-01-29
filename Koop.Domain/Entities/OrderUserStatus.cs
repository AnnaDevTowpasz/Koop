using Koop.Domain.Common;

namespace Koop.Domain.Entities
{
    public class OrderUserStatus : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int DictionaryUserStatusId { get; set; }
        public DictionaryUserStatus UserStatus { get; set; }
    }
}
