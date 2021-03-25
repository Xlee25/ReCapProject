using Buisness.Abstract;
using Buisness.Constans.Messages;
using Core.Utilities.Results;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult ReceivePayment(Payment payment)
        {
            return new SuccessResult(Messages.PaymentCompleted);
        }
    }
}
