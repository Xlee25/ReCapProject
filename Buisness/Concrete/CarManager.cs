using System;
using System.Collections.Generic;
using System.Text;
using Buisness.Abstract;
using DataAccess.Abstract;
using DataAccess.InMemory;
using Entities.Concrete;

namespace Buisness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetCars()
        {
            return _carDal.GetCars();
        }
    }
}
