using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryFlagDal : IFlagDal
    {
        List<Flag> _flags;

        public InMemoryFlagDal()
        {
            _flags = new List<Flag>()
            {
                new Flag{ Id=1, CreateDate=DateTime.Now, IsActive=true, CreatorUserId=1, ModifiedDate=DateTime.Now, Name="Türkye", Url="../.../tr-flag.ico" }
            };
        }

        public void Add(Flag flag)
        {
            _flags.Add(flag);
        }

        public void Delete(Flag flag)
        {
            Flag flagToDelete = null;
            flagToDelete = _flags.SingleOrDefault(f=>f.Id==flag.Id);

            _flags.Remove(flagToDelete);
        }

        public List<Flag> GetAll()
        {
            return _flags.ToList();
        }

        public Flag GetById(int Id)
        {
            return _flags.Where(f => f.Id == Id).FirstOrDefault();
        }

        public void Update(Flag flag)
        {
            Flag flagToUpdate = null;

            flagToUpdate =_flags.SingleOrDefault(f=>f.Id==flag.Id);

            flagToUpdate.IsActive = flag.IsActive;
            flagToUpdate.Name = flag.Name;
            flagToUpdate.Url = flag.Url;
            flagToUpdate.ModifiedDate = DateTime.Now;

            
        }
    }
}
