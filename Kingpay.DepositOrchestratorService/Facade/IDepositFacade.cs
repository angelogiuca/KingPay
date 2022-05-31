using Kingpay.DepositOrchestratorService.Facade.DTO;

namespace Kingpay.DepositOrchestratorService.Facade
{

    /// <summary>
    /// The facade for the deposit use cases
    /// </summary>
    public interface IDepositFacade
    {
        //string UniqueId { get; }


        /// <summary>
        /// Deposit initialization use case
        /// </summary>
        /// <param name="initiateDepositRequestDTO"></param>
        /// <returns></returns>
        ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO);
        
        /// <summary>
        /// Deposit update use case
        /// </summary>
        /// <returns></returns>
        ValueTask UpdateDeposit();
    }

    public interface ICardFacade : IDepositFacade
    {
    }


    public interface IMomoFacade : IDepositFacade
    {
    }

    public interface IOfflineFacade : IDepositFacade
    {
    }
}
