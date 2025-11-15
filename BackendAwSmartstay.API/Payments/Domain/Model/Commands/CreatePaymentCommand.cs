namespace BackendAwSmartstay.API.Payments.Domain.Model.Commands;

public record CreatePaymentCommand(int BookingId, decimal Amount, string PaymentMethod);


