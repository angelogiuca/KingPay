namespace Kingpay.DepositOrchestratorService.Models
{
    /// <summary>
    /// The response model for the deposit initiation
    /// </summary>
    public class InitiateDepositResponse
    {
        /// <summary>
        /// Internal transaction Id
        /// </summary>
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// The code indicating the result of the transaction operation
        /// </summary>
        public string ResponseCode { get; set; } = string.Empty;

        /// <summary>
        /// The description of the transaction operation
        /// </summary>
        public string ResponseMessage { get; set; } = string.Empty;
    }
}
