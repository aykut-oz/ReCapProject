using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCountryDal : ICountryDal
    {
        public void Add(Country country)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country country)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Country> GetByContinentId(int continentId)
        {
            throw new NotImplementedException();
        }

        public Country GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
