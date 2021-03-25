using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Entities.DTOs;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<CarDetailDto> GetCarDetail(int id);
        IDataResult<CarDetailAndImagesDto> GetCarDetailAndImagesDto(int carId);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int BrandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int ColorId);
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByFilter(int colorId, int brandId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
