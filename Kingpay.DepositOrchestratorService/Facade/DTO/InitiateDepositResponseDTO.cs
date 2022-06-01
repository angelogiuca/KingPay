namespace Kingpay.DepositOrchestratorService.Facade.DTO
{
    /// <summary>
    /// The DTO for InitiateDeposit response
    /// </summary>
    public record class InitiateDepositResponseDTO
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

        /// <summary>
        /// Additional parameters eventually needed (ie returnURL, partnerCallbackURL, etc...)
        /// </summary>
        public Dictionary<string, string>? Data { get; set; }
    }
}
