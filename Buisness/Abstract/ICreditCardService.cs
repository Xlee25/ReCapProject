using Core.Utilities.Results;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<List<CreditCard>> GetAll(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetCardsByUserid(int userId);
    }
}
