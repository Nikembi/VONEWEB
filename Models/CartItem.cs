using System.ComponentModel.DataAnnotations;

namespace VONEWEB.Models
{
    public class CartItem
    {
        [Key]
        public Guid CartItemId { get; set; }

        [Required]
        public Guid CartId { get; set; }
        public Product Product { get; set; }
    }
}
