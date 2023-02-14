using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    /// <summary>
    /// I stage: Created, Open, Closed
    /// II stage: Created, Open, Closed, Realisation, Done
    /// </summary>
    public class DictionaryOrderStatus : AuditableEntity
    {
        /// <summary>
        /// Status name
        /// </summary>
        public string Status { get; set; }
        public List<Order> Orders { get; private set; } = new List<Order>();
    }
}
