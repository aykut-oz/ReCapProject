using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService:IEntityService<Rental>
    {
        IResult CheckReturnDate(int carId);
        IResult UpdateReturnDate(int carId);

        IDataResult<Rental> GetByCustomerId(int customerId);
    }
}
