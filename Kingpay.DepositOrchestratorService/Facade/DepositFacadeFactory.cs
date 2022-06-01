using Kingpay.DepositOrchestratorService.Facade.DTO;

namespace Kingpay.DepositOrchestratorService.Facade
{
    public interface IDepositFacadeFactory
    {
        public IDepositFacade GetFacade(int instrument, string paymentMethod);
    }

    public class DepositFacadeFactory : IDepositFacadeFactory
    {
        private readonly IEnumerable<IDepositFacade> _allFacades;

        public DepositFacadeFactory(IEnumerable<IDepositFacade> allFacades)
        {
            _allFacades = allFacades;
        }

        public IDepositFacade GetFacade(int instrument, string paymentMethod)
        {
            //retrieve the flow from db given instrument and paymentMethod
            string depositFlowId = "IdFromConfigTable";

            return _allFacades.Single(x => x.DepositFlowId == depositFlowId);
        }
    }
}
