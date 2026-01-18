namespace PayTrack.Models
{
    public class PaymentRequestDTO
    {
        public decimal Amount { get; set; } = 0;
        public string Sender { get; set; } = null!;
        public string Receiver { get; set; } = null!;
        public string SenderTitle { get; set; } = null!;
        public string ReceiverTitle { get; set; } = null!;

    }
}
