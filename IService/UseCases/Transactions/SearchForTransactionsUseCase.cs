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
    public class SearchForTransactionsUseCase : ISearchForTransactionsUseCase
    {
        private readonly ITransactionService transactionService;

        public SearchForTransactionsUseCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public IEnumerable<Transaction> Execute(DateTime From, DateTime To)
        {
            return transactionService.Search(From, To);
        }
    }
}
