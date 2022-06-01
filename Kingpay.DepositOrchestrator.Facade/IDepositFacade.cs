using Kingpay.DepositOrchestrator.Facade.DTO;

namespace Kingpay.DepositOrchestrator.Facade
{

    /// <summary>
    /// The facade for the deposit use cases
    /// </summary>
    public interface IDepositFacade
    {
        /// <summary>
        /// A unique identifier for the flow
        /// </summary>
        string DepositFlowId { get; }

        /// <summary>
        /// Deposit initialization use case
        /// </summary>
        /// <param name="initiateDepositRequestDTO"></param>
        /// <returns></returns>
        ValueTask<InitiateDepositResponseDTO> InitiateDepositAsync(InitiateDepositRequestDTO initiateDepositRequestDTO);
        
        /// <summary>
        /// Deposit settlement use case
        /// </summary>
        /// <returns></returns>
        ValueTask SettleDeposit();
    }

    public interface ICardDepositFacade : IDepositFacade
    {
    }


    public interface IMoMoDepositFacade : IDepositFacade
    {
    }

    public interface IOfflineDepositFacade : IDepositFacade
    {
    }
}
