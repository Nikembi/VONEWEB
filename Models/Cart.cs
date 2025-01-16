namespace VONEWEB.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
