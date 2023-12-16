
using Core.Dto;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Account
{
    public class SignInUseCase : ISignInUseCase
    {
        private readonly IAccountRepositry accountRepositry;

        public SignInUseCase(IAccountRepositry accountRepositry)
        {
            this.accountRepositry = accountRepositry;
        }

        //public void Execute(AddAccountDto account)
        //{
        //    accountRepositry.AddAccount(account);
        //}
    }
}
