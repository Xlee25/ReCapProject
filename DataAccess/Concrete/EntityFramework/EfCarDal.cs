using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
     

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in filter is null ? context.Cars : context.Cars.Where(filter)
                             join col in context.Color
                             on car.ColorId equals col.Id
                             join bra in context.Brand
                             on car.BrandId equals bra.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = bra.Id,
                                 ColorId = col.Id,
                                 BrandName = bra.Name,
                                 ColorName = col.Name,
                                 Name = car.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear
                             };

                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetail(int id)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars.Where(c=>c.Id== id)
                             join col in context.Color
                             on car.ColorId equals col.Id
                             join bra in context.Brand
                             on car.BrandId equals bra.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = bra.Id,
                                 ColorId = col.Id,
                                 BrandName = bra.Name,
                                 ColorName = col.Name,
                                 Name = car.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
