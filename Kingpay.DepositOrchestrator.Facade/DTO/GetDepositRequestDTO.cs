namespace Kingpay.DepositOrchestrator.Facade.DTO
{
    public class GetDepositRequestDTO
    {
        public string TransactionId { get; set; }  = string.Empty;
        public string PartnerTransactionId { get; set; } = string.Empty;
    }
}
