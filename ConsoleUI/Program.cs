using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.InMemory;
using Buisness.Concrete;
using Entities.Concrete;
using Buisness.Abstract;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.ModelYear +" "+car.Description);
            }
        }
    }
}
