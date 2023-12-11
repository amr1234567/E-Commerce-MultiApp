namespace IService.UseCasesInterfaces.Transactions
{
    public interface IRemoveTransactionUseCase
    {
        void Execute(int TransactionId);
    }
}