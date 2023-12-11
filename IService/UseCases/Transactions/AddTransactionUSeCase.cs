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
    public class AddTransactionUSeCase : IAddTransactionUSeCase
    {
        private readonly ITransactionService transactionService;

        public AddTransactionUSeCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public void Execute(Transaction transaction)
        {
            transactionService.AddTransaction(transaction);
        }
    }
}
