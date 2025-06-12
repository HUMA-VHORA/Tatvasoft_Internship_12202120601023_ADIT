using Mission.Entities.Models;
using Mission.Repositories.Interface;
using Mission.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services
{
    public class AdminUserService(IAdminUserRepository _adminUserRepository) : IAdminUserService
    {
        public List<UserDetails> UserDetailsList()
        {
            return _adminUserRepository.UserDetailsList();
        }
        public string UpdateUser(UpdateUserRequestModel model)
        {
            return _adminUserRepository.UpdateUser(model);
        }
        public string AddUser(AddUserRequestModel model)
        {
            return _adminUserRepository.AddUser(model);
        }
    }
}
