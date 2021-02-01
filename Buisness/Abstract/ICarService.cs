using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Buisness.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
    }
}
