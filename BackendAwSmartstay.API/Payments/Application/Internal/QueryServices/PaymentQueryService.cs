using BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;
using BackendAwSmartstay.API.Payments.Domain.Model.Queries;
using BackendAwSmartstay.API.Payments.Domain.Repositories;
using BackendAwSmartstay.API.Payments.Domain.Services;

namespace BackendAwSmartstay.API.Payments.Application.Internal.QueryServices;


public class PaymentQueryService(IPaymentRepository paymentRepository)
    : IPaymentQueryService
{
    public async Task<Payment?> Handle(GetPaymentByIdQuery query)
    {
        return await paymentRepository.FindByIdAsync(query.PaymentId);
    }

    public async Task<IEnumerable<Payment>> Handle(GetAllPaymentsQuery query)
    {
        return await paymentRepository.ListAsync();
    }

    public async Task<IEnumerable<Payment>> Handle(GetPaymentsByBookingIdQuery query)
    {
        var payments = await paymentRepository.ListAsync();
        return payments.Where(p => p.BookingId == query.BookingId);
    }
}

