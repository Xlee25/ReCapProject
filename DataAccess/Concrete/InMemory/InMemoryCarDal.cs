using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, Description = "Bmw M5", ModelYear = "2020"},
                new Car {Id = 2, BrandId = 1, ColorId = 2, Description = "Mercedes CLA 45 AMG", ModelYear = "2016"},
                new Car {Id = 3, BrandId = 2, ColorId = 3, Description = "Range Rover Sport 2021", ModelYear = "2021"},
                new Car {Id = 4, BrandId = 2, ColorId = 4, Description = "Aston Martin Vantage V12", ModelYear = "2016"},
                new Car {Id = 5, BrandId = 3, ColorId = 5, Description = "Tofas Dogan Slx", ModelYear = "1998"},
            };
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void GetById(Car car)
        {
            Car CarGetById;
            CarGetById = _cars.First(c => c.Id == car.Id);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete;
            CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(CarToDelete);

        }

        public void Update(Car car)
        {
            Car CarToUpdate;
            CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
        }
    }
}
