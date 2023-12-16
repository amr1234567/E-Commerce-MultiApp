using Core;
using Core.Dto;
using IService.IServiceContract;
using IService.UseCases.Account;
using IService.UseCasesInterfaces.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AccountServiceInMemory : IAccountRepositry
    {

        public AccountServiceInMemory()
        {

        }
        //public void AddAccount(AddAccountDto account)
        //{
        //    if (account != null)
        //    {

        //    } 
        //}

        //    public void ChangePassword(AddAccountDto account)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void ConfirmEmail()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void DeleteAccount(Guid accountId)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void EditAccount(AddAccountDto account)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void EditRole(Guid accountId, string roleName)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Login(Account account)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void LogOut(Guid accountId)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
