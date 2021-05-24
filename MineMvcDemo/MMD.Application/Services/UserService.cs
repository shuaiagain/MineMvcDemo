using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MMD.Application.Interfaces;
using MMD.Application.ViewModels;
using MMD.Data.Entity.Interfaces;
using MMD.Infrastructure.Data;

namespace MMD.Application.Services
{
    public class UserService : IUserServices
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserVM> GetAll()
        {
            return null;
            //return _userRepository.GetAll().ProjectTo<UserVM>();
        }

        public UserVM GetById(Guid id)
        {
            return null;
            //return _mapper.Map<UserVM>(_userRepository.GetById(id));
        }

        public void Register(UserVM userVM)
        {
            //var registerCommand = _mapper.Map<RegisterNewCustomerCommand>(userVM);
        }

        public void Remove(Guid id)
        {
            //var removeCommand = new RemoveCustomerCommand(id);
        }

        public void Update(UserVM userVM)
        {
            //var updateCommand = _mapper.Map<UpdateCustomerCommand>(userVM);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
