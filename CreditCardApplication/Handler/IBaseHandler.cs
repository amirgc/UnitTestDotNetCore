using CreditCardApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplication.Handler
{
    public interface IBaseHandler<TModel>
    {
        List<CreditCardHistory> GetUserCreditHistoryByUserId();
        List<TModel> GetListOfUsers();
    }
}
