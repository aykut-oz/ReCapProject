using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService : IEntityService<User>
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string mail);
        
    }
}
