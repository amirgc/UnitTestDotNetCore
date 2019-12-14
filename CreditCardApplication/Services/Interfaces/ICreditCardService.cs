using CreditCardApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplication.Services
{
    public interface ICreditCardService<TModel>
    {
        List<CreditCardHistory> GetUserCreditHistoryByUserId();
        List<TModel> GetListOfUsers();
    }
}
