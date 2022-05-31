using Kingpay.DepositOrchestratorService.Facade.DTO;

namespace Kingpay.DepositOrchestratorService.Facade
{
    public interface IDepositFacadeFactory
    {
        public IDepositFacade GetFacade(InitiateDepositRequestDTO initiateDepositRequestDTO);
    }

    


    public class DepositFacadeFactory : IDepositFacadeFactory
    {
        private readonly IEnumerable<IDepositFacade> _allFacades;

        public DepositFacadeFactory(IEnumerable<IDepositFacade> allFacades)
        {
            _allFacades = allFacades;
        }

        public IDepositFacade GetFacade(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            /// Read from config table
            /// <summary>
            /// brandid, intrusment key, facadename
            /// </summary>

            //return _allFacades.Single(x => x.UniqueId == "IdFromConfigTable")

            throw new NotImplementedException();
        }
    }
}
