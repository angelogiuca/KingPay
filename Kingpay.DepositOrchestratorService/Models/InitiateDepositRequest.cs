namespace Kingpay.DepositOrchestratorService.Models
{
    /// <summary>
    /// The deposit request model
    /// </summary>
    public record class InitiateDepositRequest
    {
        /// <summary>
        /// Betking unique user id
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// The amount to deposit
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The instrument of the payment
        /// </summary>
        public string Instrument { get; set; } = string.Empty;

        /// <summary>
        /// The payment method chosen for the deposit
        /// </summary>
        public string PaymentMethod { get; set; } = string.Empty;

        /// <summary>
        /// The Ip address of the remote request (not from the Kingpay services)
        /// </summary>
        public string PaymentIpAddress { get; set; } = string.Empty;

        /// <summary>
        /// Additional parameters eventually needed (ie returnURL, partnerCallbackURL, etc...)
        /// </summary>
        public Dictionary<string, string>? Data { get; set; } 
    }
}
