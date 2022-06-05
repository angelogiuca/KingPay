using Kingpay.DepositOrchestrator.Domain.Entities;

namespace Kingpay.DepositOrchestrator.Services.Interfaces
{
    /// <summary>
    /// The deposit service
    /// </summary>
    public interface IDepositService
    {
        /// <summary>
        /// Retrieve the payment transaction by either transaction id or partner transaction id
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="partnerTransactionId"></param>
        /// <returns></returns>
        ValueTask<Deposit> GetDepositAsync(string transactionId, string partnerTransactionId);

        /// <summary>
        /// Sets the last Payment Method
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="paymentMethod"></param>
        /// <returns></returns>
        ValueTask<Deposit> CreateDepositAsync(string userId, string paymentMethod);

        /// <summary>
        /// Responsible for setting the first successful deposit of a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        ValueTask<Deposit> UpdateDepositAsync(string userId, string transactionId);
    }
}
