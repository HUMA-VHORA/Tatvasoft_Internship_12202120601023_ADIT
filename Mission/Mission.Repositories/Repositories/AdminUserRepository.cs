using Mission.Entities;
using Mission.Entities.Context;
using Mission.Entities.Models;
using Mission.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories
{
    public class AdminUserRepository(MissionDbContext _missionDb) : IAdminUserRepository
    {
        public List<UserDetails> UserDetailsList()
        {
            var res = _missionDb.User.Where(x => !x.IsDeleted && x.UserType == "user").Select(x => new UserDetails(x));
            return res.ToList();
        }
        public string UpdateUser(UpdateUserRequestModel model)
        {
            var user = _missionDb.User.FirstOrDefault(x => x.Id == model.Id);
            if (user == null)
                throw new Exception("User not found");

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.EmailAddress = model.EmailAddress;
            user.ModifiedDate = DateTime.Now;

            _missionDb.User.Update(user);
            _missionDb.SaveChanges();

            return "User updated!";
        }
        public string AddUser(AddUserRequestModel model)
        {
            // Optional: Check if user with same email exists to avoid duplicates
            var existingUser = _missionDb.User.FirstOrDefault(x => x.EmailAddress == model.EmailAddress && !x.IsDeleted);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            var newUser = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                EmailAddress = model.EmailAddress,
                Password = model.Password, // Consider hashing password in production
                UserType = model.UserType ?? "user",
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            _missionDb.User.Add(newUser);
            _missionDb.SaveChanges();

            return "User added successfully!";
        }
    }
}
