using BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;
using BackendAwSmartstay.API.Shared.Domain.Repositories;

namespace BackendAwSmartstay.API.Payments.Domain.Repositories;

/// <summary>
///     Represents the payment repository in the hotel management system.
/// </summary>
public interface IPaymentRepository : IBaseRepository<Payment>
{
}

