using BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;
using BackendAwSmartstay.API.Payments.Domain.Model.Commands;
using BackendAwSmartstay.API.Payments.Domain.Repositories;
using BackendAwSmartstay.API.Payments.Domain.Services;
using BackendAwSmartstay.API.Shared.Domain.Repositories;

namespace BackendAwSmartstay.API.Payments.Application.Internal.CommandServices;


public class PaymentCommandService(
    IPaymentRepository paymentRepository,
    IUnitOfWork unitOfWork)
    : IPaymentCommandService
{
    public async Task<Payment?> Handle(CreatePaymentCommand command)
    {
        var payment = new Payment(command);
        await paymentRepository.AddAsync(payment);
        await unitOfWork.CompleteAsync();

        return payment;
    }

    public async Task<Payment?> Handle(ProcessPaymentCommand command)
    {
        var payment = await paymentRepository.FindByIdAsync(command.PaymentId);
        if (payment is null) return null;

        payment.Process();
        if (!string.IsNullOrEmpty(command.InvoiceNumber))
        {
            payment.SetInvoiceNumber(command.InvoiceNumber);
        }

        paymentRepository.Update(payment);
        await unitOfWork.CompleteAsync();

        return payment;
    }

    public async Task<Payment?> Handle(FailPaymentCommand command)
    {
        var payment = await paymentRepository.FindByIdAsync(command.PaymentId);
        if (payment is null) return null;

        payment.Fail();
        paymentRepository.Update(payment);
        await unitOfWork.CompleteAsync();

        return payment;
    }
}

