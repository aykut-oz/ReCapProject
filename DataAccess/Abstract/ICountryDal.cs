using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICountryDal: IEntityRepository<Country>
    {
       
        List<Country> GetByContinentId(int continentId);
    }
}
