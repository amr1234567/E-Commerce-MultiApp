using Core;

namespace IService.UseCasesInterfaces.Transactions
{
    public interface IGetTransactionByIdUseCase
    {
        Transaction Execute(int TransactionId);
    }
}