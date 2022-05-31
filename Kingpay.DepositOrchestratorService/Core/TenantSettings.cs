namespace Kingpay.DepositOrchestratorService.Core
{
    public class TenantSettings
    {
        public Configuration? Defaults { get; set; }
        public List<Tenant>? Tenants { get; set; }
    }

    public class Configuration
    {
        public string DBProvider { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
    }
}
