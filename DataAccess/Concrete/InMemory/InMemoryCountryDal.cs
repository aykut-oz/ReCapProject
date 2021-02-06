using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCountryDal : ICountryDal
    {
        public void Add(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public Country Get(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetByContinentId(int continentId)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
