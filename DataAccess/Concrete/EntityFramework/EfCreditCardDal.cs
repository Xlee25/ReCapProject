using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardDal : EfEntityRepositoryBase<CreditCard, ReCapProjectContext>, ICreditCardDal
    {

    }
}
