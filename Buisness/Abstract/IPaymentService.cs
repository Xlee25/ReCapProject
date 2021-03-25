using Core.Utilities.Results;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IPaymentService
    {
        IResult ReceivePayment(Payment payment);
    }
}
