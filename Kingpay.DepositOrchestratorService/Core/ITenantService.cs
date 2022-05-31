namespace Kingpay.DepositOrchestratorService.Core
{
    /// <summary>
    /// This service identifies the tenant
    /// </summary>
    public interface ITenantService
    {
        public string GetDatabaseProvider();
        public string GetConnectionString();
        public Tenant GetTenant();
    }
}
