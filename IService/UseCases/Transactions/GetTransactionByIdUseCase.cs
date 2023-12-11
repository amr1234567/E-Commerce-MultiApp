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
    public class GetTransactionByIdUseCase : IGetTransactionByIdUseCase
    {
        private readonly ITransactionService transactionService;

        public GetTransactionByIdUseCase(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        public Transaction Execute(int TransactionId)
        {
            return transactionService.GetTransaction(TransactionId);
        }
    }
}
