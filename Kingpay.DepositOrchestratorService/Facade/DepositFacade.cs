using Kingpay.DepositOrchestratorService.Facade.DTO;
using Kingpay.DepositOrchestratorService.Services;

namespace Kingpay.DepositOrchestratorService.Facade
{
    public abstract class BaseFacade : IDepositFacade
    {
        private readonly IDepositService _depositService;

        public BaseFacade(IDepositService depositService)
        {
            _depositService = depositService;
        }

        public string UniqueId => throw new NotImplementedException();

        public ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            // Do my validation stuff
            throw new NotImplementedException();
        }

        public ValueTask UpdateDeposit()
        {
            throw new NotImplementedException();
        }
    }

    /// 
    /// /// <inheritdoc/>
    public class DepositFacade : BaseFacade, IDepositFacade
    {
        public DepositFacade(IDepositService depositService) :
            base(depositService)
        {

        }

        /// <inheritdoc/>
        public async ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO)
        {
            //common validations happens here

            //prepare the response
            InitiateDepositResponseDTO initiateDepositResponseDTO = new InitiateDepositResponseDTO
            {
                TransactionId = "123",
                ResponseCode = "OK",
                ResponseMessage = "OK"
            };

            //execute common action for every deposit

            //orcherstrate
            switch (initiateDepositRequestDTO.Instrument)
            {


                case 0:
                    //offline flow
                    /*
                     * risk befor edpeosit, only NG
                     * 
                     * depositService.CreatePayment(createPaymentDTO);
                     * 
                     * if (deposit == success)
                     * {
                     *      if (ethiopia and ghana tenants)
                     *          var task1 = _userDepositManager.SetLastDepositPaymentMethodAsync(data.TpsUserId, depositPaymentMethod);
                     *      
                     * 
                     *      
                     *      var task2 = _userDepositManager.SetFirstDepositTransactionIdAsync(data.TpsUserId,
                                                                result.TypedValue.TransactionIdentifier.ToString());
                            var task3 = _userDepositManager.SetHasPerformedDepositAsync(data.TpsUserId);
                    ValueTask.WaitAll(task1, task2, task3);
                       }
                     */
                    break;
                case 1:
                    //momo flow
                    break;
                case 2:
                    //card flow
                    break;
                default:
                    break;
            }

            return await ValueTask.FromResult(initiateDepositResponseDTO);
        }

        /// <inheritdoc/>
        public async ValueTask UpdateDeposit()
        {
            throw new NotImplementedException();
        }
    }

    public class CardDepositFacade : BaseFacade, ICardFacade
    {
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
}
