using Mission.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IServices
{
    public interface IAdminUserService
    {
        List<UserDetails> UserDetailsList();
        string UpdateUser(UpdateUserRequestModel model);
        string AddUser(AddUserRequestModel model);
    }
}
