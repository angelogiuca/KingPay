namespace Kingpay.DepositOrchestratorService.Core
{
    /// <summary>
    /// The tenant
    /// </summary>
    public interface ITenant
    {
        /// <summary>
        /// The tenant id
        /// </summary>
        public string TenantId { get; set; }
    }

    /// <inheritdoc/>
    public class Tenant : ITenant
    {
        /// <inheritdoc/>
        public string TenantId { get; set; } = string.Empty;

        /// <inheritdoc/>
        public string Name { get; set; } = string.Empty;

        /// <inheritdoc/>
        public string ConnectionString { get; set; } = string.Empty;  
    }
}
