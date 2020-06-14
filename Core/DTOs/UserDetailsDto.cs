using System;
using System.Collections.Generic;
using System.Text;

namespace TempProject.Core.DTOs
{
   public class UserDetailsDto
    {
        public string UserName { get; set; }
        //public string LastName { get; set; }
        //public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //public ICollection<UserRole> UserRoles { get; set; }
        //public string UserRoles { get; set; }
        //public int Assigned_Manager { get; set; }
        //public string License { get; set; }
        //public DateTime Created { get; set; }
        public string Password { get; set; }
    }
}
