using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join brand in context.Brand
                             on car.BrandId equals brand.Id
                             join color in context.Color
                            on car.ColorId equals color.Id
                             select new RentalDetailDto 
                             {
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 Id = rental.Id,
                                 BrandName = brand.Name,
                                 CarDesctiption = car.Description,
                                 ColorName = color.Name,
                                 CompanyName = customer.CompanyName,
                                 DailyPrice = car.DailyPrice,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = car.ModelYear

                             };
                return result.ToList();

            }
        }
    }
}
