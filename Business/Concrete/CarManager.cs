using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
           return _icarDal.GetAll();
        }

        public List<Car> GetByBrandOrColorId(int brandId, int? colorId)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
