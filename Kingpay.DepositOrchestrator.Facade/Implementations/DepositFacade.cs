using Kingpay.DepositOrchestrator.Facade.DTO;
using Kingpay.DepositOrchestrator.Facade.Interfaces;
using Kingpay.DepositOrchestrator.Services.Interfaces;

namespace Kingpay.DepositOrchestrator.Facade.Implementations
{
    public abstract class BaseDepositFacade : IDepositFacade
    {
        protected IDepositService _depositService;

        public virtual string DepositFlowId => throw new NotImplementedException();

        public BaseDepositFacade(IDepositService depositService)
        {
            _depositService = depositService;
        }

        public virtual ValueTask<GetDepositResponseDTO> GetDepositAsync(GetDepositRequestDTO request)
        {
            //validation
            return ValueTask.FromResult(new GetDepositResponseDTO());
        }

        //public abstract ValueTask<InitiateDepositResponse> InitiateDepositAsync(InitiateDepositRequest initiateDepositRequestDTO);
    }



    public class CardDepositFacade : BaseDepositFacade, IDepositFacade
    {
        public override string DepositFlowId => "card";

        public CardDepositFacade(IDepositService depositService) :
            base(depositService)
        {
        }

        public async override ValueTask<GetDepositResponseDTO> GetDepositAsync(GetDepositRequestDTO request)
        {
            var validation = await base.GetDepositAsync(request);

            var result = await _depositService.GetDepositAsync(request.TransactionId, request.PartnerTransactionId);

            return await ValueTask.FromResult(new GetDepositResponseDTO 
            {
                TransactionId = "123",
                PartnerTransactionId = "abc",
                Amount = result.Amount
            });
        }
    }



    public class MoMoDepositFacade : BaseDepositFacade, IDepositFacade
    {
        public override string DepositFlowId => "MoMo";

        public MoMoDepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }

    }



    public class OfflineDepositFacade : BaseDepositFacade, IDepositFacade
    {
        public override string DepositFlowId => "DepositOffline1";

        public OfflineDepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }
    }
}
