using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (MyDbContext context = new MyDbContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on r.CarId equals ca.Id
                             join cus in context.Customers
                             on r.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.Id equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName = ca.Name,
                                 CustomerCode = cus.CustomerCode,
                                 CarId = ca.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();

            }
        }
    }
}
