using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _iCarImageDal;

        public CarImageManager(ICarImageDal iCarImageDal)
        {
           _iCarImageDal = iCarImageDal;
        }

        public IResult Add(CarImage entity)
        {
            _iCarImageDal.Add(entity);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage entity)
        {
            _iCarImageDal.Delete(entity);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_iCarImageDal.GetAll());

        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage entity)
        {
            _iCarImageDal.Update(entity);
            return new SuccessResult(Messages.CarImageUpdated);
        }
    }
}
