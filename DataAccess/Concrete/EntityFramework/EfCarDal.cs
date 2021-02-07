using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                  Id=c.Id,  Code=c.Code, DailyPrice= c.DailyPrice, BrandName=b.Name
                             };
                return result.ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
