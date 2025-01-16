﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VONEWEB.Models
{
    public class Transaction
    {
        [Key]
        public Guid TransactionID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid OrderId { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required]
        [MaxLength(100)]
        public string PaymentGatewayTransactionID { get; set; }

        [Required]
        [MaxLength(20)]
        public string PaymentMethod { get; set; } // E.g., "Credit Card", "PayPal"

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Pending"; // Possible values: "Pending", "Completed", "Failed"

        public string FailureReason { get; set; }
    }
}
