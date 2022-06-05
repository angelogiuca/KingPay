using Kingpay.DepositOrchestrator.Domain.Entities;
using Kingpay.DepositOrchestrator.Services.Interfaces;

namespace Kingpay.DepositOrchestrator.Services.Implementations
{
    /// <inheritdoc/>
    public class DepositService : IDepositService
    {
        /// <inheritdoc/>
        public ValueTask<Deposit> CreateDepositAsync(string userId, string paymentMethod)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ValueTask<Deposit> GetDepositAsync(string transactionId, string partnerTransactionId)
        {
            return new ValueTask<Deposit>(new Deposit 
            {
                TransactionId = "123",
                PartnerTransactionId = "abc",
                Amount = 999
            });
        }

        /// <inheritdoc/>
        public ValueTask<Deposit> UpdateDepositAsync(string userId, string transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
