using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using VONEWEB.Enums;

namespace VONEWEB.Models
{
    public class User : IdentityUser<Guid>
    {
        public User () 
        {
            ProfilePictureUrl = string.Empty;
            Cart = new List<Cart>();
            Transaction = new List<Transaction>();
            OrderHistory = new List<OrderHistory>();
        }

        [Required]
        [MaxLength(20)]
        public UserRole Role { get; set; } // Possible values: "backer", "creator", "admin"

        [Url]
        public string ProfilePictureUrl { get; set; }

        [MaxLength(500)]
        
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
        public ICollection<OrderHistory> OrderHistory { get; set; }
    }
}
