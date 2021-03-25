using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.InMemory;
using Buisness.Concrete;
using Entities.Concrete;
using Buisness.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager();

        }
        private static void ProductManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.ModelYear + "/" + car.Description);
                }
            }
                Console.WriteLine(result.Message);
        }
    }
}
