namespace Kingpay.DepositOrchestrator.Facade.DTO
{
    public class GetDepositResponseDTO
    {
        public string TransactionId { get; set; } = string.Empty;
        public string PartnerTransactionId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }
}
