using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TransactionServiceInMemory : ITransactionService
    {
        private List<Transaction> _transactions;

        public TransactionServiceInMemory()
        {
            _transactions = new List<Transaction>();
        }
        public void AddTransaction(Transaction transaction)
        {
            if (transaction != null)
                _transactions.Add(transaction);
        }

        public void EditTransaction(Transaction transaction)
        {
            var trans = GetTransaction(transaction.Id);
            if (trans != null)
            {
                trans.TotalPrice = transaction.TotalPrice;
                trans.SoldQty = transaction.SoldQty;
                trans.Products = transaction.Products;
                trans.IsDone = transaction.IsDone;
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactions;
        }

        public Transaction GetTransaction(int transactionId)
        {
            var transaction = _transactions.FirstOrDefault(t => t.Id == transactionId);
            return transaction;
        }

        public void RemoveTransaction(int transactionId)
        {
            var transaction = GetTransaction(transactionId);
            if(transaction != null)
                _transactions.Remove(transaction);
        }

        public List<Transaction> Search(DateTime startDate, DateTime endDate)
        {
            var rangeTransactions = _transactions.Where(t => t.CreateDate.Date >= startDate && t.CreateDate.Date <= endDate);
            if (rangeTransactions.Count() > 0 && rangeTransactions != null)
                return rangeTransactions.ToList();
            else
                return null;
        }
    }
}
