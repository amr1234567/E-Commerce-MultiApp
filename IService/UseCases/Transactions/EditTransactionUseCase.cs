using Core;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Transactions
{
    public class EditTransactionUseCase : IEditTransactionUseCase
    {
        private readonly ITransactionService transactionService;

        public EditTransactionUseCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public void Execute(Transaction transaction)
        {
            transactionService.EditTransaction(transaction);
        }
    }
}
