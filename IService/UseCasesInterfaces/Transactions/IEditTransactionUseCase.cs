using Core;

namespace IService.UseCasesInterfaces.Transactions
{
    public interface IEditTransactionUseCase
    {
        void Execute(Transaction transaction);
    }
}