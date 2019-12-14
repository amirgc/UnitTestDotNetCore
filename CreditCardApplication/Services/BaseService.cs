using System;
using System.Collections.Generic;
using System.Text;
using CreditCardApplication.Models;

namespace CreditCardApplication.Services
{
    public abstract class BaseService<TModel> : ICreditCardService<TModel>
    {
        public abstract List<TModel> GetListOfUsers();

        public List<CreditCardHistory> GetUserCreditHistoryByUserId()
        {
            throw new NotImplementedException();
        }
    }
}
