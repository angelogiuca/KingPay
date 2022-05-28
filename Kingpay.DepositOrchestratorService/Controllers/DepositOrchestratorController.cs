using Kingpay.DepositOrchestratorService.Enums;
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
        private readonly IDepositFacade _depositFacade;

        public DepositOrchestratorController(IDepositFacade depositFacade)
        {
            _depositFacade = depositFacade;
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
            InitiateDepositRequestDTO initiateDepositRequestDTO = new()
            {
                PaymentMethod = initiateDepositRequest.PaymentMethod,
                Amount = initiateDepositRequest.Amount,
                PaymentIpAddress = initiateDepositRequest.PaymentIpAddress,
                UserId = initiateDepositRequest.UserId,
                Instrument = (int)Instrument.Offline
            };
            
            if (initiateDepositRequest.Data?.Count > 0)
            {
                initiateDepositRequestDTO.Data = new Dictionary<string, string>(initiateDepositRequest.Data);
            }

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
