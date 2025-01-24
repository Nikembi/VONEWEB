using System.ComponentModel.DataAnnotations;

namespace VONEWEB.Models
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Product Price { get; set; }
    }
}
