using System.ComponentModel.DataAnnotations;

namespace Koop.Shared.Products.Commands
{
    public class ProductInCartVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public int SupplierId { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public EUnit Unit { get; set; }
        [Required]
        public decimal Ammount { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal AvailableUnits { get; set; }
        public string Description { get; set; }
    }

    public enum EUnit { kg, szt }
}
