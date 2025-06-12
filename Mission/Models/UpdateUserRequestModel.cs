using System;

namespace Mission.Entities.Models
{
    public class UpdateUserRequestModel
    {
        public int Id { get; set; } // Required to identify which user to update
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        // Optional: you can add more fields if needed
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
