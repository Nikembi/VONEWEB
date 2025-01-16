namespace VONEWEB.Models
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
