using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IContinentDal
    {
        List<Continent> GetAll();

        void Add(Continent continent);
        void Delete(Continent continent);
        void Update(Continent continent);
        Continent GetById(int Id);
    }
}
