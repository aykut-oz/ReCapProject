using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetAll();

        void Add(Color car);
        void Delete(Color car);
        void Update(Color car);
        Color GetById(int Id);
    }
}
