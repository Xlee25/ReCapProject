using Buisness.Abstract;
using Buisness.Constans.Messages;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Buisness.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        private readonly ICarService _carService;
        private readonly ICustomerService _customerService;

        public RentalManager(IRentalDal rentalDal, ICarService carService, ICustomerService customerService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
            _customerService = customerService;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null);

            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalNotAdded);
            }

            var businessRules = BusinessRules.Run(FindeksScoreCheck(rental.CustomerId, rental.CarId));

            if (businessRules != null)
                return businessRules;

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id), Messages.RentalListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentalListed);
        }

        public IResult CheckReturnDate(int carId)
        {
            throw new NotImplementedException();
        }
        public IResult UpdateReturnDate(int carId)
        {
            throw new NotImplementedException();
        }

        private IResult FindeksScoreCheck(int customerId, int carId)
        {
            var customerFindexPoint = _customerService.GetById(customerId).Data.FindexPoint;

            if (customerFindexPoint == 0)
                return new ErrorResult(Messages.CustomerFindexPointIsZero);

            var carFindexPoint = _carService.GetById(carId).Data.MinFindeks;

            if (customerFindexPoint < carFindexPoint)
                return new ErrorResult(Messages.CustomerScoreIsInsufficient);

            return new SuccessResult();
        }
    }
}
