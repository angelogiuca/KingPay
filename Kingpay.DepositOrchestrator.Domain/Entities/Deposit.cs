namespace Kingpay.DepositOrchestrator.Domain.Entities
{
    public class Deposit
    {
        public string TransactionId { get; set; } = string.Empty;
        public string PartnerTransactionId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
