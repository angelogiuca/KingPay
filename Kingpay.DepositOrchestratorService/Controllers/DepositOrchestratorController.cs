using Kingpay.DepositOrchestratorService.Facade;
using Kingpay.DepositOrchestratorService.Facade.DTO;
using Kingpay.DepositOrchestratorService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kingpay.GatewayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositOrchestratorController : ControllerBase
    {
        private readonly IDepositFacadeFactory _depositFacadeFactory;
        private IDepositFacade _depositFacade { get; set; }

        public DepositOrchestratorController(IDepositFacadeFactory depositFacadeFactory)
        {
            _depositFacadeFactory = depositFacadeFactory;
        }

        [HttpGet]
        [Route("Ping")]
        public async ValueTask<string> Ping()
        {
            return await ValueTask.FromResult("Pong");
        }


        [HttpPost]
        [Route("InitiateDeposit")]
        public async ValueTask<InitiateDepositResponse> InitiateDeposit(InitiateDepositRequest initiateDepositRequest)
        {
            string paymentMethod = initiateDepositRequest.PaymentMethod;
            int instrument = Convert.ToInt32(initiateDepositRequest.Instrument);

            InitiateDepositRequestDTO initiateDepositRequestDTO = new()
            {
                PaymentMethod = paymentMethod,
                Amount = initiateDepositRequest.Amount,
                PaymentIpAddress = initiateDepositRequest.PaymentIpAddress,
                UserId = initiateDepositRequest.UserId,
                Instrument = instrument
            };
            
            if (initiateDepositRequest.Data?.Count > 0)
            {
                initiateDepositRequestDTO.Data = new Dictionary<string, string>(initiateDepositRequest.Data);
            }

            _depositFacade = _depositFacadeFactory.GetFacade(instrument, paymentMethod);

            InitiateDepositResponseDTO initiateDepositResponseDTO = await _depositFacade.InitiateDepositAsync(initiateDepositRequestDTO);

            InitiateDepositResponse initiateDepositResponse = new()
            {
                TransactionId = initiateDepositResponseDTO.TransactionId,
                ResponseCode = initiateDepositResponseDTO.ResponseCode,
                ResponseMessage = initiateDepositResponseDTO.ResponseMessage
            };

            return await ValueTask.FromResult(initiateDepositResponse);
        }
    }
}
