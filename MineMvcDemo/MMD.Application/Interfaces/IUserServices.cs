using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MMD.Application.ViewModels;


namespace MMD.Application.Interfaces
{
    public interface IUserServices
    {
        void Register(UserVM userVM);
        IEnumerable<UserVM> GetAll();
        UserVM GetById(Guid id);
        void Update(UserVM userVM);
        void Remove(Guid id);
    }
}
