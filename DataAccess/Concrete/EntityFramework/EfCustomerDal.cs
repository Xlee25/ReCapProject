using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailsDto()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users on customer.UserId equals user.Id
                             select new CustomerDetailDto()
                             {
                                Id = customer.Id,
                                userId = user.Id,
                                CompanyName = customer.CompanyName,
                                FirstName = user.FirstName,
                                LastName = user.LastName,
                                Email = user.Email,
                                FindexPoint = customer.FindexPoint
                             };
                return result.ToList();
            }
        }
    }
}
