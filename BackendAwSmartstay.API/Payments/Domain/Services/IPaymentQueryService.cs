using BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;
using BackendAwSmartstay.API.Payments.Domain.Model.Queries;

namespace BackendAwSmartstay.API.Payments.Domain.Services;

/// <summary>
///     Represents the payment query service in the hotel management system.
/// </summary>
public interface IPaymentQueryService
{
    /// <summary>
    ///     Handles the get payment by id query.
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetPaymentByIdQuery" /> query to handle.
    /// </param>
    /// <returns>
    ///     The <see cref="Payment" /> entity if found, otherwise null.
    /// </returns>
    Task<Payment?> Handle(GetPaymentByIdQuery query);

    /// <summary>
    ///     Handles the get all payments query.
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetAllPaymentsQuery" /> query to handle.
    /// </param>
    /// <returns>
    ///     A collection of all payments.
    /// </returns>
    Task<IEnumerable<Payment>> Handle(GetAllPaymentsQuery query);

    /// <summary>
    ///     Handles the get payments by booking id query.
    /// </summary>
    /// <param name="query">
    ///     The <see cref="GetPaymentsByBookingIdQuery" /> query to handle.
    /// </param>
    /// <returns>
    ///     A collection of payments filtered by booking id.
    /// </returns>
    Task<IEnumerable<Payment>> Handle(GetPaymentsByBookingIdQuery query);
}

