using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class SystemAdmin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Fullname { get; set; }
        public string MobileNumber { get; set; }

        public SystemAdmin(string username, string password, string mobileNumber)
        {
            Username = username;
            Password = password;
            MobileNumber = mobileNumber;
        }
    }
}
