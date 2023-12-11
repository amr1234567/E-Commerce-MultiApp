using Core;

namespace IService.UseCasesInterfaces.Transactions
{
    public interface IGetAllTransactionsUseCase
    {
        IEnumerable<Transaction> Execute();
    }
}