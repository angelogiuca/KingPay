namespace Kingpay.DepositOrchestratorService.Services
{
    /// <summary>
    /// The deposit service
    /// </summary>
    public interface IDepositService
    {
        /// <summary>
        /// Sets the last Payment Method
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="paymentMethod"></param>
        /// <returns></returns>
        ValueTask CreatePayment(string userId, string paymentMethod);

        /// <summary>
        /// Responsible for setting the first successful deposit of a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        ValueTask UpdatePayment(string userId, string transactionId);
    }

    /// <inheritdoc/>
    public class DepositService : IDepositService
    {
        /// <inheritdoc/>
        public async ValueTask CreatePayment(string userId, string transactionId)
        {
            //CE to expose endpoint for updating user extra details
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public async ValueTask UpdatePayment(string userId, string paymentMethod)
        {
            //CE to expose endpoint for updating user extra details
            throw new NotImplementedException();
        }
    }
}
