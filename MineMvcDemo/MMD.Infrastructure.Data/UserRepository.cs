using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MMD.Data.Entity.Interfaces;
using MMD.Data.Entity.User;

namespace MMD.Infrastructure.Data
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserEntity GetByAccountId(Guid accountId)
        {
            throw new NotImplementedException();
        }
    }
}
