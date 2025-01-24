using System.ComponentModel.DataAnnotations;

namespace VONEWEB.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string Description { get; set; }

        [MaxLength(255)]
        public string ImageUrl { get; set; }

        [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00")]
        public decimal Price { get; set; }
        [Range(0.01, 10000.00)]
        public decimal CostPrice { get; set; }
    }
}
