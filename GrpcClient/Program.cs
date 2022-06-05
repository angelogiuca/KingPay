using Grpc.Net.Client;
using Kingpay.DepositOrchestratorService.Protos;

GetDepositRequest data = new ()
{ 
    TransactionId = "txid",
    PartnerTransactionId = "partnertxid"
};

var grpcChannel = GrpcChannel.ForAddress("https://localhost:5155");
var client = new DepositOrchestrationControllerGrpc.DepositOrchestrationControllerGrpcClient(grpcChannel);
var response = await client.GetDepositAsync(data);
Console.WriteLine(response.TransactionId);
Console.WriteLine(response.PartnerTransactionId);
Console.WriteLine(response.Amount);
Console.ReadLine();
