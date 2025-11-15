using BackendAwSmartstay.API.Payments.Domain.Model.Commands;

namespace BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;

public partial class Payment
{
    public Payment()
    {
        PaymentMethod = string.Empty;
    }

    public Payment(int bookingId, decimal amount, string paymentMethod) : this()
    {
        BookingId = bookingId;
        Amount = amount;
        PaymentMethod = paymentMethod;
        Status = PaymentStatus.Pending;
        PaymentDate = DateTime.UtcNow;
    }


    public Payment(CreatePaymentCommand command) : this(
        command.BookingId,
        command.Amount,
        command.PaymentMethod)
    {
    }


    public int Id { get; }


    public int BookingId { get; private set; }
    
    public decimal Amount { get; private set; }

    public string PaymentMethod { get; private set; }

    public PaymentStatus Status { get; private set; }
    
    public DateTime PaymentDate { get; private set; }

    public string? InvoiceNumber { get; private set; }


    public void Process()
    {
        Status = PaymentStatus.Processed;
    }


    public void Fail()
    {
        Status = PaymentStatus.Failed;
    }

    public void SetInvoiceNumber(string invoiceNumber)
    {
        InvoiceNumber = invoiceNumber;
    }
}

public enum PaymentStatus
{
    Pending = 0,
    Processed = 1,
    Failed = 2,
    Refunded = 3
}

