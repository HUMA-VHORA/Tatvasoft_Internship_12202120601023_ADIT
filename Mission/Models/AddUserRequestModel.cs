using System;

namespace Mission.Entities.Models
{
    public class AddUserRequestModel
    {
        public AddUserRequestModel()
        {
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string UserType { get; set; } = "user"; // default to "user", can be changed
    }
}