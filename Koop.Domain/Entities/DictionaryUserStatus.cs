using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    public class DictionaryUserStatus : AuditableEntity
    {
        /// <summary>
        /// Status name
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Calculated: 10% or 30%
        /// </summary>
        public int PerCent { get; set; }
        /// <summary>
        /// Is fee paid?
        /// </summary>
        public bool IsActive { get; set; }
        public List<OrderUserStatus> OrderUserStatuses { get; private set; } = new List<OrderUserStatus>();
    }
}
