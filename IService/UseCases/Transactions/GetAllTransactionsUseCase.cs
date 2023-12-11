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
    public class GetAllTransactionsUseCase : IGetAllTransactionsUseCase
    {
        private readonly ITransactionService transactionService;

        public GetAllTransactionsUseCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public IEnumerable<Transaction> Execute()
        {
            return transactionService.GetAllTransactions();
        }
    }
}
