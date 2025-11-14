using BackendAwSmartstay.API.Payments.Domain.Model.Aggregates;
using BackendAwSmartstay.API.Payments.Domain.Model.Commands;

namespace BackendAwSmartstay.API.Payments.Domain.Services;

/// <summary>
///     Represents the payment command service in the hotel management system.
/// </summary>
public interface IPaymentCommandService
{
    /// <summary>
    ///     Handles the create payment command.
    /// </summary>
    /// <param name="command">
    ///     The <see cref="CreatePaymentCommand" /> command to handle.
    /// </param>
    /// <returns>
    ///     The created <see cref="Payment" /> entity.
    /// </returns>
    public Task<Payment?> Handle(CreatePaymentCommand command);

    /// <summary>
    ///     Handles the process payment command.
    /// </summary>
    /// <param name="command">
    ///     The <see cref="ProcessPaymentCommand" /> command to handle.
    /// </param>
    /// <returns>
    ///     The processed <see cref="Payment" /> entity.
    /// </returns>
    public Task<Payment?> Handle(ProcessPaymentCommand command);

    /// <summary>
    ///     Handles the fail payment command.
    /// </summary>
    /// <param name="command">
    ///     The <see cref="FailPaymentCommand" /> command to handle.
    /// </param>
    /// <returns>
    ///     The failed <see cref="Payment" /> entity.
    /// </returns>
    public Task<Payment?> Handle(FailPaymentCommand command);
}

