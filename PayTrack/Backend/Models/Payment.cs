using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayTrack.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReferenceNo { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sender { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Receiver { get; set; } = null!;


        [Required]
        [MaxLength(100)]
        public string SenderTitle { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string ReceiverTitle { get; set; } = null!;

        [Required]
        public PaymentStatus Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
 
}
