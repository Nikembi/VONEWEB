using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VONEWEB.Models
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; set; }
        [Required]
        [ForeignKey("CartId")]
        public Guid ProductId { get; set; }
        [Required]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Product Price { get; set; }
    }
}
