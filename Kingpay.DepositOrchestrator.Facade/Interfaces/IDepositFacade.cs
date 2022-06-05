using Kingpay.DepositOrchestrator.Facade.DTO;

namespace Kingpay.DepositOrchestrator.Facade.Interfaces
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
        /// Deposit retrieval use case
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ValueTask<GetDepositResponseDTO> GetDepositAsync(GetDepositRequestDTO request);

        /// <summary>
        /// Deposit initialization use case
        /// </summary>
        /// <param name="initiateDepositRequestDTO"></param>
        /// <returns></returns>
        //Task<InitiateDepositResponse> InitiateDepositAsync(InitiateDepositRequest initiateDepositRequestDTO);
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
