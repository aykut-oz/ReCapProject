using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService: IEntityService
    {
        //List<Car> GetAll();
        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
        //Car GetById(int Id);
        //List<Car> GetByBrandOrColorId(int brandId, int? colorId);
        //List<Car> GetCarsByBrandId(int brandId);
        //List<Car> GetCarsByColorId(int colorId);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
    }
}
