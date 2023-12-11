using Core;

namespace IService.UseCasesInterfaces.Transactions
{
    public interface IAddTransactionUSeCase
    {
        void Execute(Transaction transaction);
    }
}