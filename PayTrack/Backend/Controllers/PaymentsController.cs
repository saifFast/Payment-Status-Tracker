using Microsoft.AspNetCore.Mvc;
using PayTrack.Database;
using PayTrack.Models;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public PaymentsController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // ✅ Create Payment
    [HttpPost]
    public IActionResult CreatePayment(PaymentRequestDTO request)
    {
        var payment = new Payment
        {
            ReferenceNo = Guid.NewGuid().ToString("N"),
            Amount = request.Amount,
            Sender = request.Sender,
            Receiver = request.Receiver,
            Status = PaymentStatus.Pending,
            CreatedAt = DateTime.UtcNow,
            SenderTitle = request.SenderTitle,
            ReceiverTitle = request.ReceiverTitle
        };

        _dbContext.Payments.Add(payment);
        _dbContext.SaveChanges();

        return Ok(payment);
    }

    // ✅ Get All Payments
    [HttpGet]
    public IActionResult GetPayments()
    {
        var payments = _dbContext.Payments
            .OrderByDescending(p => p.CreatedAt)
            .ToList();

        return Ok(payments);
    }

    // ✅ Get Payment By Reference
    [HttpGet("{referenceNo}")]
    public IActionResult GetPaymentByReference(string referenceNo)
    {
        var payment = _dbContext.Payments
            .FirstOrDefault(p => p.ReferenceNo == referenceNo);

        if (payment == null)
            return NotFound();

        return Ok(payment);
    }
}
