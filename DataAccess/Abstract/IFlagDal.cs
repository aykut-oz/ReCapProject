using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFlagDal
    {
        List<Flag> GetAll();

        void Add(Flag flag);
        void Delete(Flag flag);
        void Update(Flag flag);
        Flag GetById(int Id);

    }
}
