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
                var result = from car in filter == null ? context.Cars:context.Cars.Where(filter)
                             join col in context.Colors
                             on car.ColorId equals col.Id
                             join bra in context.Brands
                             on car.BrandId equals bra.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = bra.Id,
                                 ColorId = col.Id,
                                 BrandName = bra.Name,
                                 ColorName = col.Name,
                                 MinFindeks = car.MinFindeks,
                                 Name = car.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,                      
                             };

                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetail(int id)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars.Where(c=>c.Id== id)
                             join col in context.Colors
                             on car.ColorId equals col.Id
                             join bra in context.Brands
                             on car.BrandId equals bra.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = bra.Id,
                                 ColorId = col.Id,
                                 BrandName = bra.Name,
                                 ColorName = col.Name,
                                 MinFindeks = car.MinFindeks,
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
