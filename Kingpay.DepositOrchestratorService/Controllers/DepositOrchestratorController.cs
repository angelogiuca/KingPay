using Grpc.Core;
using Kingpay.DepositOrchestrator.Facade.DTO;
using Kingpay.DepositOrchestrator.Facade.Interfaces;
using Kingpay.DepositOrchestratorService.Protos;

namespace Kingpay.DepositOrchestratorService.Controllers
{
    public class DepositOrchestratorController : DepositOrchestrationControllerGrpc.DepositOrchestrationControllerGrpcBase
    {
        private readonly IDepositFacadeFactory _factory;

        public DepositOrchestratorController(IDepositFacadeFactory factory)
        {
            _factory = factory;
        }

        public override async Task<GetDepositResponse> GetDeposit(GetDepositRequest request, ServerCallContext context)
        {
            IDepositFacade facade = _factory.GetFacade("card", "paymentmethod");

            GetDepositRequestDTO getDepositRequestDTO = new GetDepositRequestDTO 
            {
                TransactionId = request.TransactionId,
                PartnerTransactionId = request.PartnerTransactionId
            };

            GetDepositResponseDTO? depositResponseDTO = await facade.GetDepositAsync(getDepositRequestDTO);

            GetDepositResponse getDepositResponse = new ()
            {
                TransactionId = depositResponseDTO.TransactionId,
                PartnerTransactionId = depositResponseDTO.PartnerTransactionId,
                Amount = Convert.ToDouble(depositResponseDTO.Amount)
            };

            return getDepositResponse;
        }
    }
}
