using Buisness.Abstract;
using Buisness.Constans.Messages;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        //[SecuredOperation("admin,user")]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Add(CreditCard creditCard)
        {
            var result = BusinessRules.Run(IsCardExist(creditCard));
            if (result != null)
            {
                return result;
            }

            _creditCardDal.Add(creditCard);
            return new SuccessResult();
        }

        [SecuredOperation("admin,user")]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult();
        }

        [SecuredOperation("admin,user")]
        [CacheRemoveAspect("ICreditCardService.Get")]
        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public IDataResult<List<CreditCard>> GetAll(CreditCard creditCard)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(p => p.CardNumber == creditCard.CardNumber && p.NameOnTheCard == creditCard.NameOnTheCard && p.CVV == creditCard.CVV));
        }

        public IDataResult<List<CreditCard>> GetCardsByUserid(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CustomerId == userId));
        }

        //BUISNESS RULES
        private IResult IsCardExist(CreditCard creditCard)
        {
            var result = _creditCardDal.Get(card => card.CustomerId == creditCard.CustomerId && card.CardNumber == creditCard.CardNumber);

            if (result != null)
            {
                return new ErrorResult(Messages.CardExist);
            }

            return new SuccessResult();
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
