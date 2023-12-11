using IService.IServiceContract;
using IService.UseCasesInterfaces.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Transactions
{
    public class RemoveTransactionUseCase : IRemoveTransactionUseCase
    {
        private readonly ITransactionService transactionService;

        public RemoveTransactionUseCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public void Execute(int TransactionId)
        {
            transactionService.RemoveTransaction(TransactionId);
        }
    }
}
