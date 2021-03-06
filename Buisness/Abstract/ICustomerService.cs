﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetByUserId(int userId);
    }
}
