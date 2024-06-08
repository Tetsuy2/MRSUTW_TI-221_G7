using System;

namespace Calatorii.Domain.Entities.User
{
    public class URegisterData
    {
        public string Credential { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RegisterIp { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public string Role { get; set; } // Add this property
    }
}
