using Koop.Domain.Common;
using System.Collections.Generic;

namespace Koop.Domain.Entities
{
    /// <summary>
    /// New, Done
    /// </summary>
    public class DictionaryCartStatus : AuditableEntity
    {
        /// <summary>
        /// Status name
        /// </summary>
        public string Status { get; set; }
        public List<Cart> Carts { get; private set; } = new List<Cart>();
    }
}
