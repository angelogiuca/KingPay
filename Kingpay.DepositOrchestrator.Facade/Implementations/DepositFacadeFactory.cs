using Kingpay.DepositOrchestrator.Facade.Interfaces;

namespace Kingpay.DepositOrchestrator.Facade.Implementations
{
    public class DepositFacadeFactory : IDepositFacadeFactory
    {
        private readonly IEnumerable<IDepositFacade> _allFacades;

        public DepositFacadeFactory(IEnumerable<IDepositFacade> allFacades)
        {
            _allFacades = allFacades;
        }

        public IDepositFacade GetFacade(string instrument, string paymentMethod)
        {
            //retrieve the flow from db given instrument and paymentMethod
            //string depositFlowId = "IdFromConfigTable";

            return _allFacades.Single(x => x.DepositFlowId == instrument);
        }
    }
}
