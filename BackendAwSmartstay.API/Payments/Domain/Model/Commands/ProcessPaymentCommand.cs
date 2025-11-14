namespace BackendAwSmartstay.API.Payments.Domain.Model.Commands;

public record ProcessPaymentCommand(int PaymentId, string? InvoiceNumber = null);

