namespace Kingpay.DepositOrchestrator.Facade.DTO
{
    /// <summary>
    /// The DTO to map the InitiateDepositRequest
    /// </summary>
    public class InitiateDepositRequestDTO
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
        /// The amount of the fees (if any)
        /// </summary>
        public decimal Fees { get; set; }

        /// <summary>
        /// The payment instrument
        /// </summary>
        public int Instrument { get; set; }

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
