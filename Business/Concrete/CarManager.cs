using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;

        public CarManager(ICarDal icarDal)
        {
            _icarDal = icarDal;
        }

        public IResult Add(Car car)
        {
            if (car.Name.Length < 2)
            {
               
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _icarDal.Add(car);  
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
