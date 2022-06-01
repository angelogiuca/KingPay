using Kingpay.DepositOrchestrator.Facade.DTO;
using Kingpay.DepositOrchestrator.Services;

namespace Kingpay.DepositOrchestrator.Facade
{
    public abstract class BaseFacade
    {
        private readonly IDepositService _depositService;

        public BaseFacade(IDepositService depositService)
        {
            _depositService = depositService;
        }

        public virtual string DepositFlowId => throw new NotImplementedException();

        public ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            // Do my validation stuff
            throw new NotImplementedException();
        }

        public ValueTask SettleDeposit()
        {
            throw new NotImplementedException();
        }
    }

    public class CardDepositFacade : BaseFacade, ICardDepositFacade
    {
        public override string DepositFlowId => "Card";

        public CardDepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }

        public ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            //var result = InitiateDepositResponseDTO();
            //result.
            base.InitiateDepositAsync(initiateDepositRequestDTO);


            //return new { Data = new}

            throw new NotImplementedException();
        }

        public ValueTask UpdateDeposit()
        {
            throw new NotImplementedException();
        }
    }

    public class MoMoDepositFacade : BaseFacade, IMoMoDepositFacade
    {
        public override string DepositFlowId => "MoMo";

        public MoMoDepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }

        public ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            //var result = InitiateDepositResponseDTO();
            //result.
            base.InitiateDepositAsync(initiateDepositRequestDTO);


            //return new { Data = new}

            throw new NotImplementedException();
        }

        public ValueTask UpdateDeposit()
        {
            throw new NotImplementedException();
        }
    }

    public class OfflineDepositFacade : BaseFacade, IOfflineDepositFacade
    {
        public override string DepositFlowId => "DepositOffline1";

        public OfflineDepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }

        public ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            //var result = InitiateDepositResponseDTO();
            //result.
            base.InitiateDepositAsync(initiateDepositRequestDTO);

            throw new NotImplementedException();
        }

        public ValueTask UpdateDeposit()
        {
            throw new NotImplementedException();
        }
    }
}
