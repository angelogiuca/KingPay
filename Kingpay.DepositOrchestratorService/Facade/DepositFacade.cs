using Kingpay.DepositOrchestratorService.Facade.DTO;

namespace Kingpay.DepositOrchestratorService.Facade
{
    /// <inheritdoc/>
    public class DepositFacade : IDepositFacade
    {
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

            //orcherstrate
            switch (initiateDepositRequestDTO.Instrument)
            {
                case 0:
                    //offline flow
                    /*
                     * save the transactio to db
                     * if (deposit == success)
                     * {
                     *      if (ethiopia and ghana tenants)
                     *          var task1 = _userDepositManager.SetLastDepositPaymentMethod(data.TpsUserId, depositPaymentMethod);
                     *          
                     *      var task2 = _userDepositManager.SetFirstDepositTransactionId(data.TpsUserId,
                                                                result.TypedValue.TransactionIdentifier.ToString());
                            var task3 = _userDepositManager.SetHasPerformedDeposit(data.TpsUserId);
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
}
