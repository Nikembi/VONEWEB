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
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
    }
}
