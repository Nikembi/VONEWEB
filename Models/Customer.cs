using System.ComponentModel.DataAnnotations;

namespace VONEWEB.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
    }
}
