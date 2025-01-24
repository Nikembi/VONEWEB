using System.ComponentModel.DataAnnotations;
using VONEWEB.Enums;

namespace VONEWEB.Models
{
    public class Guest
    {
        [Key]
        public Guid GuestId { get; set; }
        [Required]
        public UserRole Role { get; set; } // Possible values: "user", "vip", "admin, guests"
        [MaxLength(20)]
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
    }
}
