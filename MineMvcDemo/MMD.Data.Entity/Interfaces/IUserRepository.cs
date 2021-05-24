using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MMD.Data.Entity.User;

namespace MMD.Data.Entity.Interfaces
{
    /// <summary>
    /// IUserRepository 接口
    /// 注意，这里我们用到的业务对象，是领域对象
    /// 定义一些特有的接口
    /// </summary>
    public interface IUserRepository : IRepository<UserEntity>
    {
        UserEntity GetByAccountId(Guid accountId);
    }
}
