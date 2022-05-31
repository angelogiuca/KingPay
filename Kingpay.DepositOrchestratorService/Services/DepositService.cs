namespace Kingpay.DepositOrchestratorService.Services
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
        /// <param name="partnerId"></param>
        /// <returns></returns>
        ValueTask GetPaymentAsync(string transactionId, string partnerTransactionId);

        /// <summary>
        /// Sets the last Payment Method
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="paymentMethod"></param>
        /// <returns></returns>
        ValueTask CreatePaymentAsync(string userId, string paymentMethod);

        /// <summary>
        /// Responsible for setting the first successful deposit of a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        ValueTask UpdatePaymentAsync(string userId, string transactionId);
    }

    /// <inheritdoc/>
    public class DepositService : IDepositService
    {
        /// <inheritdoc/>
        public async ValueTask GetPaymentAsync(string transactionId, string partnerId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async ValueTask CreatePaymentAsync(string userId, string transactionId)
        {
            //get merchant financy system endpoint url
            //post http payment command (integrations-betking.services/CreateTransaction)
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async ValueTask UpdatePaymentAsync(string userId, string paymentMethod)
        {
            //get merchant financy system endpoint url
            //post http payment command (integrations-betking.services/UpdateTransactionStatus)
            throw new NotImplementedException();
        }
    }
}
