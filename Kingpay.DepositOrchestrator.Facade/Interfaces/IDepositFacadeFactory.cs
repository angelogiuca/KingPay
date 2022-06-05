namespace Kingpay.DepositOrchestrator.Facade.Interfaces
{
    public interface IDepositFacadeFactory
    {
        public IDepositFacade GetFacade(string instrument, string paymentMethod);
    }
}
