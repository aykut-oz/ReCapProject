using Core.DataAccess;
using Entities.Concrete;

namespace Business.Concrete
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {

    }
}