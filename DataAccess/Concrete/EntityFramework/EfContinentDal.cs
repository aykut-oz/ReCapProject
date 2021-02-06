using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContinentDal : IContinentDal
    {
        public void Add(Continent entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Continent entity)
        {
            throw new NotImplementedException();
        }

        public Continent Get(Expression<Func<Continent, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Continent> GetAll(Expression<Func<Continent, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Continent entity)
        {
            throw new NotImplementedException();
        }
    }
}
