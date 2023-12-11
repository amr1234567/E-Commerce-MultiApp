using Core;

namespace IService.UseCasesInterfaces.Transactions
{
    public interface ISearchForTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(DateTime From, DateTime To);
    }
}