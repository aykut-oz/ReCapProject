using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICountryDal
    {
        List<Country> GetAll();

        void Add(Country country);
        void Delete(Country country);
        void Update(Country country);
        Country GetById(int Id);
        List<Country> GetByContinentId(int continentId);
    }
}
