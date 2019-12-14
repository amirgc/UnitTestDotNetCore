using System;
using System.Collections.Generic;
using System.Text;
using CreditCardApplication.Models;
using CreditCardApplication.Services;

namespace CreditCardApplication.Handler
{
    public class BaseHandler<TModel> : IBaseHandler<TModel>
    {
        private readonly ICreditCardService<TModel> _creditCardService;

        public BaseHandler(ICreditCardService<TModel> creditCardService)
        {
            _creditCardService = creditCardService;
        }

        public List<TModel> GetListOfUsers()
        {
            return _creditCardService.GetListOfUsers();
        }

        public List<CreditCardHistory> GetUserCreditHistoryByUserId()
        {
            return _creditCardService.GetUserCreditHistoryByUserId();
        }

    }
}
