using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        public IResult Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Country>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
